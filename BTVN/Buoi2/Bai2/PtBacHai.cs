using System;

namespace Bai2
{
    class PtBacHai
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.WriteLine("Nhập a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Nhập b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Nhập c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            double delta = b*b - 4*a*c;
            double x1, x2;

            Console.WriteLine("Phương trình bậc hai: "+ "ax^2 + bx + c = 0 <=> {0}x^2 + {1}x + {2} = 0 ", a, b, c);
            Console.WriteLine("=> Delta = "+ "b^2 - 4ac = {0}^2 - 4*{1}*{2} = {3}", b , a , c , (float)delta);
            
            if (delta < 0) {
                Console.WriteLine("Delta < 0 nên phương trình vô nghiệm");
            } else if(delta == 0) {
                x1 = x2 = ((float)-b/(2*a));
                Console.WriteLine("Delta = 0 nên phương trình có nghiệm kép: x1 = x2 = -b/2a = {0}", x1);
            }
            else {
                x1 = (float)((-b + Math.Sqrt(delta))/(2*a));
                x2 = (float)((-b - Math.Sqrt(delta))/(2*a));
                Console.WriteLine("Delta > 0 nên phương trình có 2 nghiệm: x1 = {0} và x2 = {1} ", x1, x2);
            } 
        }
    }
}
