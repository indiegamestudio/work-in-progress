using System;
using System.IO;

namespace bobs_boxes_1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("input.txt");
            StreamWriter writer = new StreamWriter("output.txt");

            while (reader.Peek()!= -1)
            {
                string line = reader.ReadLine();

                string[] parts = line.Split(',');

                int length = Convert.ToInt32(parts[0]);
                int width = Convert.ToInt32(parts[1]);
                int height = Convert.ToInt32(parts[2]);

                int volume = length * width * height;

                writer.WriteLine("The volume of the {0} * {1} * {2} box is {3}.", length, width, height, volume);
            }
            reader.Close();
            writer.Close();
        }
    }
}
