#define DEBUG // Об этом начиная с 82-ой страницы.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Описание Region'на
/// <summary>
/// Region определяет область комментариев.
/// </summary>
#endregion
namespace ConsoleApp1
{
    class Program
    {
        enum Constants : ushort // Перечесление констант
        {
            OneT = 0,
            Two = 30000,
            Three = 30000
        }
        
        static void Main(string[] args)
        {
            short y = -31;
#if (DEBUG) // Об этом начиная с 82-й страницы.
            ushort x = 0;
            
            Console.WriteLine((ushort)Constants.OneT); // Вывод одной из констант(OneT)
            x = 30000;
#else // Об этом начиная с 82-й страницы.
            switch (y)
            {
                case -31: goto case 4;
                case 4:
                case 5:
                    Console.WriteLine("Yes");
                    break;

                default:

                    Console.WriteLine("No");
                    break;
            }
#endif // Об этом начиная с 82-й страницы.
            Console.ReadLine();
        }
    }
}
