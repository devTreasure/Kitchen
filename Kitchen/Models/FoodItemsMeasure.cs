using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Kitchen.Models
{
    public class FoodItemsMeasure
    {
        [Key]
        public int ingredientsID { get; set; }
        [ForeignKey("ItemID")]
        public int ItemID { get; set; }
   
       
        public  double weightUse { get; set; }
        public DateTime prepDate { get; set; }
    }
}