using System;

namespace RestaurantDesserts
{
    // Base class for all desserts
    abstract class Dessert
    {
        // Common step
        public void AddSugar()
        {
            Console.WriteLine("Step 1: Add Sugar");
        }

        // Abstract method for the unique preparation
        public abstract void Prepare();

        // Common step
        public void Serve()
        {
            Console.WriteLine("Step 3: Serve to the Customer\n");
        }

        // Template method that calls all steps in order
        public void MakeDessert()
        {
            AddSugar();
            Prepare();   // Dessert-specific step
            Serve();
        }
    }

    // Ice-cream dessert
    class IceCream : Dessert
    {
        public override void Prepare()
        {
            Console.WriteLine("Step 2: Churn and Freeze the mixture");
        }
    }

    // Cake dessert
    class Cake : Dessert
    {
        public override void Prepare()
        {
            Console.WriteLine("Step 2: Bake in the oven");
        }
    }

    // Gulab Jamun dessert
    class GulabJamun : Dessert
    {
        public override void Prepare()
        {
            Console.WriteLine("Step 2: Fry dough balls and soak in syrup");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create objects for each dessert
            Dessert iceCream = new IceCream();
            Dessert cake = new Cake();
            Dessert gulabJamun = new GulabJamun();

            Console.WriteLine("=== Ice-Cream Preparation ===");
            iceCream.MakeDessert();

            Console.WriteLine("=== Cake Preparation ===");
            cake.MakeDessert();

            Console.WriteLine("=== Gulab Jamun Preparation ===");
            gulabJamun.MakeDessert();
        }
    }
}
