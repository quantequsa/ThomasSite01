using DataAccessSite07;
using System;
using System.Linq;
namespace ThomasSite01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ThomasSite01 - Shop Info Tool!");
            Console.WriteLine("Write 'help' to list available commands By Tim, " +
  "write 'quit' to exit application by Thomas");

            var coffeeShopDataProvider = new CoffeeShopDataProvider();

            while (true)
            {
                var line = Console.ReadLine();

                if (string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();

                ///Optimize even further using the conditional operator
                ///If equal to help use ? else use :
                ///
                //ICommandHandler commandHandler;  //Call this commandHandler just once to optimize further
                ///Optimized code in the Program.cs using two command Handlers with two HandleCommand method with the same name.
                ///We could optimize further if we have an interface for both command handlers so place cursor in the HelpCommandHandler class and press ctrl. to extract interface
                ///initialize the variable directly here and let's check if the string that was entered by the use equals 'help' and if true just use the new HelpCommandHandler else use the new CoffeeShopCommandHandler
                //ICommandHandler commandHandler =
                var commandHandler =
                    string.Equals("help", line, StringComparison.OrdinalIgnoreCase)
                    ? new HelpCommandHandler(coffeeShops) as ICommandHandler   //use explicitly since there is no implicit conversion between HelpCommandHandler and CoffeeShopCommandHandler
                    : new CoffeeShopCommandHandler(coffeeShops, line);

                /*
                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    //var commandHandler = new HelpCommandHandler(coffeeShops);
                    commandHandler = new HelpCommandHandler(coffeeShops); //ctrl. creates a class in a new file and we need to instantiate from this new class just created : HelpCommandHandler
                    //commandHandler.HandleCommand();                           //ctrl. create a new method in the CoffeeShopCommandHandler newly created
                    ///Need to MOVE because it got to big: using two inputs coffeeShops from this program.cs
                    //Console.WriteLine("> Available coffee shop commands:");
                    //foreach (var coffeeShop in coffeeShops)
                    //{
                    //    Console.WriteLine($"> " + coffeeShop.Location);
                    //}
                }
                else
                {
                    //var commandHandler = new CoffeeShopCommandHandler(coffeeShops, line);
                    commandHandler = new CoffeeShopCommandHandler(coffeeShops, line);  //ctrl. creates a class in a new file and we need to instantiate from this new class just created : CoffeeShopCommandHandler
                */
                //commandHandler.HandleCommand();                                        //ctrl. create a new method in the CoffeeShopCommandHandler newly created
                ///Here is the new class CoffeeShopCommandHandler
                /*
                using DataAccessSite07.Model;
                using System.Collections.Generic;

                namespace ThomasSite01
                {
                    internal class CoffeeShopCommandHandler
                    {
                        private IEnumerable<CoffeeShop> coffeeShops;
                        private string line;

                        public CoffeeShopCommandHandler(IEnumerable<CoffeeShop> coffeeShops, string line)
                        {
                            this.coffeeShops = coffeeShops;
                            this.line = line;
                        }
                    }
                }
                ///added to the new method HandleCommand() to generate via ctrl. in the new class CoffeeShopCommandHandler
                using DataAccessSite07.Model;
                +++
                using System;
                ...
                            this.line = line;
                        }
                +++
                        internal void HandleCommand()
                        {
                            throw new NotImplementedException();
                        }
                */


                ///Need to MOVE because it got to big: using two inputs coffeeShops and line from this program.cs
                //var foundCoffeeShops = coffeeShops
                //.Where(x => x.Location.StartsWith(line, StringComparison.OrdinalIgnoreCase))
                //.ToList();
                //if (foundCoffeeShops.Count == 0)
                //{
                //    Console.WriteLine($"> Command '{line}' not found");
                //}
                //else if (foundCoffeeShops.Count == 1)
                //{
                //    var coffeeShop = foundCoffeeShops.Single();
                //    Console.WriteLine($"> Location: {coffeeShop.Location}");
                //    Console.WriteLine($"> Beans in stock: {coffeeShop.BeansInStockInKg} Kg");
                //}
                //else
                //{
                //    Console.WriteLine($"> Multiple matching coffee shop command found:");
                //    foreach (var coffeeType in foundCoffeeShops)
                //    {
                //        Console.WriteLine($"> {coffeeType.Location}");
                //    }
                //}
                commandHandler.HandleCommand();
            }
        }
    }
}
