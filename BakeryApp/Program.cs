using BakeryApp.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CashRegisterView());


            /*
            // Test Exercise 1

            IFood bread = new Bread(2, 50);
            Console.WriteLine("The bread costs " + bread.price + " euros and contains " + bread.calories + " calories.");

            // Test Exercise 2

            IFood bread2 = new SoftBread();
            Console.WriteLine("The softbread costs " + bread2.price + " euros and contains " + bread2.calories + " calories.");

            // Test Exercise 4

            IFood cocaCola = new Coke();
            IFood panini = new Panini();
            Menu<IFood, IFood> menu = new Menu<IFood, IFood>(cocaCola, panini);
            Console.WriteLine(menu.drink);
            Console.WriteLine(menu.meal);

            // Test Exercise 5

            Bread bread3 = new SoftBread();
            Drink drink = new Coke();
            Breakfast<Bread, Drink> breakfast = new Breakfast<Bread, Drink>(bread3, drink);
            Console.WriteLine(breakfast.meal);
            Console.WriteLine(breakfast.drink);
            */

        }
    }
}
