using WpfMvvmSimple.Common;
using WpfMvvmSimple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmSimple.ViewModels
{
    public class DishMenuItemViewModel : NotifyBase
    {
        public Dish Dish { get; set; }
        private bool isSelected;
        public bool IsSelected 
        {
            get { return isSelected; }
            set { isSelected = value; this.DoNotify("IsSelected");}
        }
    }
}
