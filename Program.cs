using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiThuThuy_1911505310266_BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int chon266;
            do
            {

                Console.WriteLine("***************MAIN MENU**********");
                Console.WriteLine("Bài 1");
                Console.WriteLine("Bài 2");
                Console.WriteLine("Bài 3");
                Console.WriteLine("Bài 4");
                Console.Write("    NHẬP LỰA CHỌN CỦA BẠN VÀO:");

                chon266 = int.Parse(Console.ReadLine());
                switch (chon266)
                {

                    case 1:
                        {
                            int songuyen266;
                            Console.Write("Mời bạn nhập số : ");
                            string input266 = Console.ReadLine();
                            songuyen266 = int.Parse(input266);
                            if (songuyen266 >= 0)
                            {
                                Console.WriteLine("Đây là số nguyên dương");
                            }
                            else
                            {
                                Console.WriteLine("Đây là số nguyên âm");

                            }
                            Console.ReadKey();
                        };
                        break;
                    case 2:
                        {
                            int n266;
                            Console.Write("Nhập vào một số nguyên :");
                            string x266 = Console.ReadLine();
                            n266 = int.Parse(x266);

                            switch (n266)
                            {
                                case 0: Console.WriteLine("Không"); break;
                                case 1: Console.WriteLine("Một"); break;
                                case 2: Console.WriteLine("Hai"); break;
                                case 3: Console.WriteLine("Ba"); break;
                                case 4: Console.WriteLine("Bốn"); break;
                                case 5: Console.WriteLine("Năm"); break;
                                case 6: Console.WriteLine("Sáu"); break;
                                case 7: Console.WriteLine("Bảy"); break;
                                case 8: Console.WriteLine("Tám"); break;
                                case 9: Console.WriteLine("Chín"); break;
                                case 10: Console.WriteLine("Mười"); break;
                                default:
                                    Console.WriteLine("Chỉ có 0 - 10 thôi");
                                    break;
                            }
                            Console.ReadKey();
                        };
                        break;
                    case 3:
                        {
                            Console.WriteLine(" Nhập vào 3 số ");
                            Console.Write(" Nhập số thứ nhất: ");
                            string a266 = Console.ReadLine();
                            float d266 = int.Parse(a266);
                            Console.Write(" Nhập số thứ hai: ");
                            string b266 = Console.ReadLine();
                            float e266 = int.Parse(b266);
                            Console.Write(" Nhập số thứ ba: ");
                            string c266 = Console.ReadLine();
                            float f266 = int.Parse(c266);
                            if (d266 + e266 > f266 && e266 + f266 > d266 && f266 + d266 > e266)
                                Console.WriteLine("Ba số đúng là 3 cạnh của 1 tam giác");
                            else
                                Console.WriteLine("Ba số không phải là 3 cạnh của 1 tam giác");

                            Console.ReadKey();
                        };
                        break;
                    case 4:
                        {
                            Console.WriteLine(" Nhập vào 3 số ");
                            Console.Write(" Nhập số thứ nhất: ");
                            string one266 = Console.ReadLine();
                            float resultone266 = int.Parse(one266);
                            Console.Write(" Nhập số thứ hai: ");
                            string two266 = Console.ReadLine();
                            float resulttwo266 = int.Parse(two266);
                            Console.Write(" Nhập số thứ ba: ");
                            string three266 = Console.ReadLine();
                            float resultthree266 = int.Parse(three266);
                            if (resultone266 * resultone266 + resulttwo266 * resulttwo266 == resultthree266 * resultthree266 || resulttwo266 * resulttwo266 + resultthree266 * resultthree266 == resultone266 * resultone266 || resultthree266 * resultthree266 + resultone266 * resultone266 == resulttwo266 * resulttwo266)
                                Console.WriteLine("Ba số đúng là 3 cạnh của 1 tam giác vuông");
                            else
                                Console.WriteLine("Ba số không phải là cạnh của 1 tam giác vuông");

                            Console.ReadKey();
                        };
                        break;
                    default:
                        {
                            Console.WriteLine("XIN MỜI NHẬP LẠI");
                        }; break;

                }
            } while (chon266 != 4);
            Console.ReadLine();
            
        }
    }
}
