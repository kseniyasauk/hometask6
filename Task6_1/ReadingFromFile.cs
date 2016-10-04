using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using log4net.Config;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Task6_1
{
    class ReadingFromFile
    {
        private static readonly ILog Logger =
           LogManager.GetLogger(typeof(ReadingFromFile));

        public void ReadFile(string path)
        {
            //BasicConfigurator.Configure();

            try
            {
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException("Path is uncorrect!");
                }

                if (new FileInfo(path).Length == 0)
                {
                    throw new FileLoadException("File is empty!");
                }

                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    StreamReader sr = new StreamReader(fs);
                    while (!sr.EndOfStream)
                    {
                        try
                        {
                            string line = sr.ReadLine();
                            if (line.Equals(""))
                            {
                                throw new Exception("Empty line!");
                            }
                            Console.WriteLine(line[0]);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Logger.Error("There is an empty line in the file");
                        }
                    }
                }


            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Logger.Fatal("File is not found!You input uncorrect path or this file is not exist!");
            }
            catch (FileLoadException e)
            {
                Console.WriteLine(e.Message);
                Logger.Fatal("Your file is empty or unreadable!");
            }



        }
    }
}
