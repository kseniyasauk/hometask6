using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_1
{
    class CommunicationWithUser
    {
        public void InputPathToFile()
        {
            Console.WriteLine("Input path to the file: ");
            string path = Console.ReadLine();

            ReadingFromFile file = new ReadingFromFile();
            file.ReadFile(path);
            
        }
    }
}
