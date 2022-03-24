using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_CallByValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============CallByValue==============");
            int val = 50;
            Console.WriteLine($"the value passed before passing to the function::{value}");
            Program obj = new Program();
            obj.Show(val);
            Console.WriteLine($"");

        }
    }

}
