using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Kitchen.Models;

namespace Kitchen.DAL
{
    public class KitchenContext : DbContext
    {

        public KitchenContext(): base("KitchenContext")
        {

        }

        public DbSet <Ingredients> Ingredients {get;set;}
        public DbSet<FoodItems> FoodItems { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<FoodItemsMeasure> FoodItemMeasure { get; set; }

        public DbSet<IngredientDetails> ingredientsDetails { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}