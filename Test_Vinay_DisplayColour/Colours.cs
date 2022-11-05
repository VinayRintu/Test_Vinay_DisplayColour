using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vinay_DisplayColour
{
    public class Colours
    {
        
        public void FindColour()
        {
            Console.WriteLine("Enter Colours first letter in 'VIBGYOR' ");
            string colour=Console.ReadLine();
           

            switch (colour)
            {
                case "V" or "v":
                    Console.WriteLine("Colour is Violet");
                    break;
                case "I" or "i":
                    Console.WriteLine("Colour is Indigo");
                        break;
                case "B" or "b":
                    Console.WriteLine("Colour is Blue");
                    break;
                case "G" or "g":
                    Console.WriteLine("Colour is Green");
                    break;
                case "Y" or "y":
                    Console.WriteLine("Colour is Yellow");
                    break;
                case "O" or "o":
                    Console.WriteLine("Colour is Orange");
                    break;
                case "R" or "r":
                    Console.WriteLine("Colour is Red");
                    break;
            }
        }
    }
}
