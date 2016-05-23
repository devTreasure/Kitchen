using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Kitchen.Models
{
    public class FoodItemDetails
    {
        [Key]
        public int  FoodItemID {get;set;}
        public DateTime CreatedDate { get; set; }
        public ICollection<FoodItemsMeasure> Weight { get; set; }
        public KitchenEnum.Departments Department { get; set; }
       // public ICollection<Ingredients> foodItem { get; set; } // we dont need ,do we ?
    }
}