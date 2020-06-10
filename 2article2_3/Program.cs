using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2article2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Никита", "Цельман" , 2004, 8, 6);
            human.SetYear(2003);
            Console.WriteLine(human.GetYear());
        }
    }
}
