using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace Kitchen.Models
{
    public class Ingredients
    {
        [Key]
        public int IngredientID { get; set; }
        public string IngredientName { get; set; }
    }
}