using WpfMvvmSimple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WpfMvvmSimple.Services
{
    public class XmlDataService : IDataService
    {
        public List<Dish> GetAllDishes()
        {
            List<Dish> dishList = new List<Dish>();
            string xmlFileName = System.IO.Path.Combine(Environment.CurrentDirectory, @"Data\Data.xml");
            XDocument xDocument = XDocument.Load(xmlFileName);
            var dishes = xDocument.Descendants("Dish");
            foreach (var item in dishes)
            {
                Dish dish = new Dish()
                {
                    Name = item.Element("Name").Value,
                    Category = item.Element("Category").Value,
                    Comment = item.Element("Comment").Value,
                    Score = item.Element("Score").Value,
                };
                dishList.Add(dish);
            }
            return dishList;
        }
    }
}
