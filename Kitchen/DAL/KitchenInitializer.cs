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

        public KitchenInitializer()
        {
            this.Seed( new KitchenContext());
        }

        protected override void Seed(KitchenContext context)
        {
            base.Seed(context);

            //Defining ingredients 

            var ingCheese = new Ingredients {
                IngredientID = 1,
                IngredientName="Cheese"
              };

            context.Ingredients.Add(ingCheese);

            var ingDough= new Ingredients
            {
                IngredientID = 2,
                IngredientName = "Dough"
            };
            context.Ingredients.Add(ingDough);
            var ingOlive = new Ingredients
            {
                IngredientID = 3,
                IngredientName = "Olive"
            };
            context.Ingredients.Add(ingOlive);
            var ingtomatoes = new Ingredients
            {
                IngredientID = 4,
                IngredientName = "Tomatoes"
            };
            context.Ingredients.Add(ingtomatoes);

            var ingJaleppinios= new Ingredients
            {
                IngredientID = 5,
                IngredientName = "Jaleppinios"
            };

            context.Ingredients.Add(ingJaleppinios);

            context.SaveChanges();

            //Actual entering into Store keeping
            var ing1 = new IngredientDetails
            {
                ID = 1,
                IntakeDate = new DateTime(2013,10, 23),
                Price = 13.5,
                Weight = 45.45
            };

            context.ingredientsDetails.Add(ing1);


            var ing2 = new IngredientDetails
            {
                ID = 2,
                IntakeDate = new DateTime(2013, 09, 23),
                Price = 11.5,
                Weight = 45.45
            };
            context.ingredientsDetails.Add(ing2);

            var ing3 = new IngredientDetails
            {
                ID = 1,
                IntakeDate = new DateTime(2013, 02, 23),
                Price = 10.5,
                Weight = 34.45
            };

            context.ingredientsDetails.Add(ing3);

            var ing4 = new IngredientDetails
            {
                ID = 1,
                IntakeDate = new DateTime(2013, 01, 23),
                Price = 9.5,
                Weight = 425.45
            };

            context.ingredientsDetails.Add(ing4);


            var ing5 = new IngredientDetails
            {
                ID = 1,
                IntakeDate = new DateTime(2013, 05, 23),
                Price = 7.5,
                Weight = 2.34
            };
            context.ingredientsDetails.Add(ing5);

            context.SaveChanges();

            //making a Food Item for mappings only - Pitza collection 
            var pitzaCollection = new List<Ingredients>();

            pitzaCollection.Add(ingCheese);
            pitzaCollection.Add(ingDough);
            pitzaCollection.Add(ingCheese);
            pitzaCollection.Add(ingOlive);
            pitzaCollection.Add(ingtomatoes);
            pitzaCollection.Add(ingJaleppinios);



            
            //Crate an Item
            var foodItem = new FoodItems { ItemName="Pitza", ItemID = 1 };
            context.FoodItems.Add(foodItem);
            context.SaveChanges();
            

            //Make an Item

            var item1Usage = new FoodItemsMeasure { ItemID=1, ingredientsID = 1, weightUse = 2.2 , prepDate= DateTime.Now};
            var item2Usage = new FoodItemsMeasure { ItemID = 1, ingredientsID = 2, weightUse = 1.2, prepDate = DateTime.Now };
            var item3Usage = new FoodItemsMeasure { ItemID = 1, ingredientsID = 3, weightUse = 0.2, prepDate = DateTime.Now };
            var item4Usage = new FoodItemsMeasure { ItemID = 1,ingredientsID = 3, weightUse = 4.1, prepDate = DateTime.Now };
            var item5Usage = new FoodItemsMeasure { ItemID = 1, ingredientsID = 4, weightUse = 1.8, prepDate = DateTime.Now };

            var listusage = new List<FoodItemsMeasure>();

            listusage.Add(item1Usage);
            listusage.Add(item2Usage);
            listusage.Add(item3Usage);
            listusage.Add(item4Usage);
            listusage.Add(item5Usage);

            listusage.ForEach(z => context.FoodItemMeasure.Add(z));
            context.SaveChanges();

            var foodItemDeails = new FoodItemDetails { CreatedDate = new DateTime(2013, 03, 23),
                                                       FoodItemID = 1 ,
                                                       Weight = listusage };

          

             

        }
    }
}