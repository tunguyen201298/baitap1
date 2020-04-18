using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            try
            {
                int number;
                int fail = 1;
                Random randoms = new Random();
                int random = randoms.Next(1, 10);
                Console.WriteLine("TRÒ CHƠI ĐOÁN SỐ");
                Console.WriteLine("----------------");
                while (fail <= 3)
                {
                    Console.WriteLine("Số bạn đoán là:");
                    number = int.Parse(Console.ReadLine());
                    if (number > 10)
                        Console.WriteLine("Số nhập vào phải nhỏ hơn 10");
                    else
                    { 
                        if (number == random)
                        {
                            Console.WriteLine("Bạn đã đoán đúng!!!-_-");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sai rồi!!!");
                            fail++;
                        }
                    }
                }
                if (fail > 3)
                {
                    Console.WriteLine("Bạn thua rồi");
                    Console.WriteLine("Kết quả là:" + random);
                }
                throw new Exception();
            }
            catch(Exception e)
            {
                Console.WriteLine("Dữ liệu nhập vào phải là số");

            }
            Console.ReadKey();
        }
    }
}
