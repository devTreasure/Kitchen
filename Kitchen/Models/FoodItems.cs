using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kitchen.Models
{
    public class FoodItems
    {

        public int ItemID { get; set; }
        public ICollection<Ingredients> Ingredients { get; set; }
        public DateTime CreatedDate { get; set; }
        public KitchenEnum.Departments Departments { get; set; }

    }
}