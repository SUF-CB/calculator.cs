using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Menu

{
    class Program
    {
        static void Main(string[] args)
        {

            int inum1 = 0;
            int inum2 = 0;
            int iResult = 0;
            char cOption;//Cannot intialise char as it will always have a unicode value, even if empty/Null

            Console.WriteLine("Menu");
            Console.WriteLine("A to add");
            Console.WriteLine("S to subtract");
            Console.WriteLine("M to multiply");
            Console.WriteLine("D to divide");
            Console.WriteLine("please enter your choice");
            cOption = char.Parse(Console.ReadLine());
            cOption = char.ToUpper(cOption);

            Console.WriteLine("please enter the first number");
            inum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            inum2 = int.Parse(Console.ReadLine());

            if (cOption == 'A')
            {
                iResult = inum1 + inum2;
            }
            else if (cOption == 'S')
            {
                iResult = inum1 - inum2;
            }
            else if (cOption == 'M')
            {
                iResult = inum1 * inum1;
            }
            else
            {
                iResult = inum1 / inum2;
            }

            Console.WriteLine("The answer is {0}", iResult);
            Console.ReadLine();















        }
    }
}
