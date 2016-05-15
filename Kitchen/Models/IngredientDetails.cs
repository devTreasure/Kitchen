using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kitchen.Models
{
    public class IngredientDetails
    {
        public int ID { get; set; }
        public int  IngredientID { get; set; }
        public DateTime IntakeDate { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        
    }
}