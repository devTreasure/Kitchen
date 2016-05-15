using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Kitchen.Models;


namespace Kitchen.DAL
{
    public class KitchenInitializer : DropCreateDatabaseIfModelChanges<KitchenContext>
    {

        protected override void Seed(KitchenContext context)
        {
            base.Seed(context);

            var ingCheese = new Ingredients {
                IngredientID = 1,
                IngredientName="Cheese"
              };
            var ingDough= new Ingredients
            {
                IngredientID = 2,
                IngredientName = "Dough"
            };
            var ingOlive = new Ingredients
            {
                IngredientID = 3,
                IngredientName = "Olive"
            };
            var ingtomatoes = new Ingredients
            {
                IngredientID = 4,
                IngredientName = "Tomatoes"
            };

            var ingJaleppinios= new Ingredients
            {
                IngredientID = 5,
                IngredientName = "Jaleppinios"
            };
        }
    }
}