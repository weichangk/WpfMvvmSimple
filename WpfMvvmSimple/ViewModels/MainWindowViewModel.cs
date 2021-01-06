using WpfMvvmSimple.Common;
using WpfMvvmSimple.Models;
using WpfMvvmSimple.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfMvvmSimple.ViewModels
{
    public class MainWindowViewModel : NotifyBase
    {
        public CommandBase PlaceOrderCommand { get; set; }
        public CommandBase SelectMenuItemCommand { get; set; }
        private int count;
        public int Count 
        {
            get { return count; }
            set { count = value; this.DoNotify("Count"); }
        }
        private Restaurant restaurant;
        public Restaurant Restaurant
        {
            get { return restaurant; }
            set { restaurant = value; this.DoNotify("Restaurant"); }
        }
        private List<DishMenuItemViewModel> dishMenu;
        public  List<DishMenuItemViewModel> DishMenu
        {
            get { return dishMenu; }
            set { dishMenu = value; this.DoNotify("DishMenu"); }
        }
        public MainWindowViewModel()
        {
            this.LoadRestaurant();
            this.LoadDishMenu();
            this.SelectMenuItemCommand = new CommandBase()
            {
                DoExecute = new Action<object>(this.SelectMenuItemCommandExecute),
                DoCanExecute = new Func<object, bool>((o) => { return true; }),
            };
            this.PlaceOrderCommand = new CommandBase() 
            {
                DoExecute = new Action<object>(this.PlaceOrderCommandExecute),
                DoCanExecute = new Func<object, bool>((o) => { return true; }),
            };
        }
        private void LoadRestaurant()
        {
            this.Restaurant = new Restaurant()
            {
                Name = "Cray大象",
                Address = "深圳北站A出口",
                PhoneNumber = "12345678901 Or 88888888",
            };
        }
        private void LoadDishMenu()
        {
            XmlDataService ds = new XmlDataService();
            var dishe = ds.GetAllDishes();
            this.DishMenu = new List<DishMenuItemViewModel>();
            foreach (var dish in dishe)
            {
                DishMenuItemViewModel dm = new DishMenuItemViewModel();
                dm.Dish = dish;
                this.DishMenu.Add(dm);
            }
        }
        private void PlaceOrderCommandExecute(object o)
        {
            var selectedDishes = this.DishMenu.Where(i => i.IsSelected == true).Select(i => i.Dish.Name).ToList();
            IOrderService orderService = new MockOrderService();
            orderService.PlaceOrder(selectedDishes);
            MessageBox.Show("订餐成功！");
        }
        private void SelectMenuItemCommandExecute(object o)
        {
            this.Count = this.DishMenu.Count(i => i.IsSelected == true);
        }
    }
}
