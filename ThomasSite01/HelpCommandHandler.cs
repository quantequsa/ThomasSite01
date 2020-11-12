using DataAccessSite07.Model;
using System;
using System.Collections.Generic;

namespace ThomasSite01
{
    /// <summary>
    /// We could optimize further if we have an interface for both command handlers so place cursor in the HelpCommandHandler class and press ctrl. to extract interface as new ICommandHandler.cs class

    /// </summary>
    public class HelpCommandHandler : ICommandHandler  //so the HelpCommandHandler implements this interface ICommandHandler from ICommandHandler.cs class
    {
        private IEnumerable<CoffeeShop> coffeeShops;

        public HelpCommandHandler(IEnumerable<CoffeeShop> coffeeShops)
        {
            this.coffeeShops = coffeeShops;
        }
        /// <summary>
        /// make this HandleCommand public and paste the original content logic we commented out from the program.cs
        /// </summary>
        //delete internal class HelpCommandHandler
        public void HandleCommand()
        {
            //throw new NotImplementedException();
            ///Need to MOVE because it got to big: using two inputs coffeeShops from this program.cs
            Console.WriteLine("> Available coffee shop commands:");
            foreach (var coffeeShop in coffeeShops)
            {
                //Console.WriteLine($"> " + coffeeShop.Location);
                Console.WriteLine($"> { coffeeShop.Location}");     //Replace with the use of an interpolated string here
            }
        }
    }
}