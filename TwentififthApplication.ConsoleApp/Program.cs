using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TwentififthApplication.ConsoleApp
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            var exceptions = new Exception[] { new CustomException("Собственное исключение"), new ArgumentOutOfRangeException(), new FileNotFoundException(), new KeyNotFoundException(), new NotImplementedException() };
            foreach (var exception in exceptions)
            {
                try
                {
                    throw exception;
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message} {ex.GetType().Name}");
                }
                finally
                {
                    Console.WriteLine("Блок finally сработал");
                }
            }
            Console.ReadKey();
        }
        
    }
}
