using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Data;

public static class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        var specials = new PizzaSpecial[]
        {
            new PizzaSpecial()
            {
                Name = "Basic Cheese Pizza",
                Description = "It's cheesy and delicious. Why wouldn't you want one?",
                BasePrice = 9.99M,
                ImageUrl = "img/pizzas/cheese.jpg"
            },
            new PizzaSpecial()
            {
                Name = "The Baconatorizor",
                Description = "It has EVERY kind of bacon",
                BasePrice = 11.99M,
                ImageUrl = "img/pizzas/bacon.jpg"
            },
            new PizzaSpecial()
            {
                Name = "Classic pepperoni",
                Description = "It's the pizza you grew up with, but Blazing hot!",
                BasePrice = 10.50M,
                ImageUrl = "img/pizzas/pepperoni.jpg"
            },
            new PizzaSpecial()
            {
                Name = "Buffalo Chicken",
                Description = "Spicy chicken, hot sauce and bleu cheese, guaranteed to warm you up",
                BasePrice = 12.75M,
                ImageUrl = "img/pizzas/meaty.jpg"
            },
            new PizzaSpecial()
            {
                Name = "Mushroom Lovers",
                Description = "It has mushrooms. Isn't that obvious?",
                BasePrice = 11.00M,
                ImageUrl = "img/pizzas/mushroom.jpg"
            },
            new PizzaSpecial()
            {
                Name = "Veggie Delight",
                Description = "It's like salad, but on a pizza",
                BasePrice = 11.50M,
                ImageUrl = "img/pizzas/salad.jpg"
            },
            new PizzaSpecial()
            {
                Name = "Margherita",
                Description = "Traditional Italian pizza with tomatoes and basil",
                BasePrice = 9.99M,
                ImageUrl = "img/pizzas/margherita.jpg"
            }
        };
        db.Specials.AddRange(specials);
        db.SaveChanges();
    }
}
