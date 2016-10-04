using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //@"d:\task6_exception.txt";
            CommunicationWithUser user = new CommunicationWithUser();
            user.InputPathToFile();
            Console.ReadKey();
        }
    }
}
