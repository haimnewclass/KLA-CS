using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA4
{
    internal class Exc
    {
        public void Run()
        {
            int num = 0;

            bool valid = false;

            while (!valid)
            { 
                string str = Console.ReadLine();
                try
                {
                    num = int.Parse(str);
                    valid = true;

                    //System.IO.File.ReadAllText(@"l:\aaa\ggg.txt");
                    Test(200);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Error Was not valid number " + ex.Message);

                }
                catch (DirectoryNotFoundException ex)
                {
                    Console.WriteLine("Format is not valid "+ex.Message);
                }
                catch(NotGreatThan100Exception ex)
                {
                    Console.WriteLine("Test Greater than 100");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Was not valid number " + ex.Message);
                }
                
                
                Console.WriteLine("Finaly");
                
            }

            Console.WriteLine(num*num);
            Console.ReadLine();


        }

        public void Test(int num)
        {
            if(num > 100)
            {
                NotGreatThan100Exception ex = new NotGreatThan100Exception("Not Valid more than 100");
                throw ex;
            }

            Console.WriteLine("Vali");
        }
    }

    class NotGreatThan100Exception : Exception
    { 
        public NotGreatThan100Exception(string msg) : base(msg) { }
    }

}
