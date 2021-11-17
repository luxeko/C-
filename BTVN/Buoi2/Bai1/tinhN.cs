using System;

namespace Buoi2
{
    class tinhN
    {
        static void Main(string[] args)
        {
            int n, i;
            float sum = 0, sumOther = 0, tong = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                System.Console.WriteLine("Nhập số nguyên dương n: ");
                n = Convert.ToInt32(Console.ReadLine());
                if(n > 0){
                    for(i = 1; i <=n; i++){
                        sum += (float) 1/i;
                        if(i % 2==0) {
		            	    tong += (float)1/i;
                        }else {
                            sumOther = sumOther + ((float)1/i);
                        }
                    }
                    System.Console.WriteLine("Biểu thức 1: 1 + 1/2 +...+ 1/{0}", n);
                    System.Console.WriteLine("Tổng biểu thức 1: {0} \n", sum );
                    System.Console.WriteLine("Biểu thức 2: 1 - 1/2 + 1/3 -... 1/{0}", n);
                    System.Console.WriteLine("Tổng biểu thức 2: {0}", (sumOther - tong));
                    break;
                }else System.Console.WriteLine("n phải là số nguyên dương");
            }
            
        }
    }
}