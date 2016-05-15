using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kitchen.Models
{
    public class FoodItemDetails
    {

        public string  FoodItemID {get;set;}
        public DateTime CreatedDate { get; set; }
        public float Weight { get; set; }
        public KitchenEnum.Departments Department { get; set; }
        public ICollection<FoodItems> foodItem { get; set; }
    }
}