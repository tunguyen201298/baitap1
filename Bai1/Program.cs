using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            string name;
            string strAge;
            Console.WriteLine("Nhập họ tên:");
            name = Console.ReadLine();

            string pattern = @"^[a-zA-Z\s]+$";

            Regex regex = new Regex(pattern);

            while (!regex.IsMatch(name))
            {
                Console.Write("Nhập lại tên lần nữa: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Nhập tuổi:");
            strAge = Console.ReadLine();

            int age = 0;
            while (!int.TryParse(strAge, out age))
                {
                    Console.Write("Nhập lại tuổi: ");
                strAge = Console.ReadLine();
                }

            Console.WriteLine("Họ tên: {0,-10}, Tuổi: {1,-5}", name, age);
                

            Console.ReadLine();
        }
    }
}
