using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bobs_boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" hi i am box master 2000 i will tell you plastic box cost ");
            Console.WriteLine(" let me ask you first what color are the boxes ");
            string color = Console.ReadLine();
            bool red = true;
            bool condition2 = true;
            bool condition3 = true;

            if (red)
                Console.WriteLine(" thank you let me get started on calculations ");

            int length = 10;

            int width = 10;

            int height = 10;

            double thicc = 2.5;

            double volume = length * width * height * thicc;

            double cost = 0.00025 * volume;

            Console.WriteLine(" a  red plastic box will cost you {0} dollers how many do you need? ", cost);
            
            string ammount = Console.ReadLine();
            
            double ammont = Convert.Todouble(Console.ReadLine());

            double cost2 = cost * ammount;




        }
    }
}
