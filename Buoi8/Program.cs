using System.Collections;
using System;

namespace Buoi8
{
    // Khai báo kiểu delegate, giá trị của delegate sẽ là hàm có cùng kiểu trả về và danh sách tham số như delegate
    public delegate void Del_Calculator(int n1, int n2);
    public delegate int MyDelegate(int n1, int n2);            
    public delegate void Del_Logger(string mess);             
    class Program
    {
        static void soSanh(int n1, int n2)
        {
            if(n1 > n2)
            {
                System.Console.WriteLine("{0} > {1}", n1,n2);
            }
            else
            {
                System.Console.WriteLine("{0} < {1}", n1,n2);
            }
        }
        static void devide(out Del_Logger logger, int num1, int num2)
        {
            if(num2 == 0)
            {
                logger = Logger.Error;
                // logger = Error
                logger("Khong the thuc hien phep tinh chia cho 0");
            }
            else
            {
                logger = Logger.Info;
                // logger = Error
                String result = String.Format("{0} / {1} = {2}", num1, num2, ((float)num1/num2));
                logger(result);
            }
        }
        static void Main(String[] args)
        {
            // Action. Func: delegate định nghĩa trước
            // Action: delegate (void: ko có kiểu trả về)
            // Action<danh sach kieu tham so> <ten bien>: delegate void <ten bien>(<danh sach tham so>);
            // Action<int, int>: delegate void TwoInt(int n1, int n2)
            Action<int, int> action2 = soSanh;
            action2(4, 6);
            action2.Invoke(4, 6);
            
            // Func: delegate(co tra ve, co return);
            // Func<string>: delegate string func0();
            Func<string> func0 = toString;
            System.Console.WriteLine(func0());
            // Func<string, string>: delegate string func1(string);
            Func<string, string> func1 = toString;
            System.Console.WriteLine(func1("abcd"));
            // Func<int, float, double>: delegate double funcAdd2(int num1, float num2);
            Func<int, float, double> funcAdd2 = add2;
            System.Console.WriteLine(funcAdd2(10, 3.14f));

            Action<Del_Calculator> actionDel = new Calculator().testDelegate;
            actionDel((int num1, int num2) => {
                int sum = 1;
                for(int i = 0; i < num2; i++)
                {
                    sum *= num1;
                }
                System.Console.WriteLine("{0}^{1} = {2}", num1, num2, sum);
            });
        }
        public static string toString()
        {
            return "Hoc ve delegate";
        }
        public static string toString(String message)
        {
            return message.ToUpper();
        }
        public static double add2(int num1, float num2)
        {
            return num1 + num2;
        }

        static void Main_Delegate()
        {
            int num = 10;
            System.Console.WriteLine(num);
            ArrayList ar = new ArrayList();
            ar.Add(1);
            Calculator calObj = new Calculator();
            // cach tao doi tuong delegate
            // gia trị của delegate là hàm / phương thức
            Del_Calculator delCal1 = new Del_Calculator(calObj.add);
            Del_Calculator delCal2 = calObj.multi;
            // thực thi hàm qua delegate tham chiếu
            calObj.add(1, 3);
            delCal1(1, 3);
            delCal1 = Program.soSanh; 
            delCal1(1, 3);
            delCal1 = delCal2;
            delCal1.Invoke(1, 3);

            delCal1 = null;            
            // ?: đối tượng delegate != null mới thực thi
            delCal1?.Invoke(1, 3);

            // delegate return void có thể +/- thêm các action như làm việc với giá trị
            delCal2 += calObj.add;
            delCal2 += soSanh;
            delCal2(2, 5);

            // biểu thức Lambda: cách viết ngắn gọn của hàm
            /*
            (< danh sach tham so >) =>{}
            */
            // delegate giá trị = hàm vô danh cùng khai báo
            Del_Calculator delCal3 = (int num1, int num2) => { 
                if (num1 != 0 && num2 % num1 == 0)
                {
                    System.Console.WriteLine("{0} la uoc cua {1}", num1, num2);
                } 
                else
                {
                    System.Console.WriteLine("{0} ko phai la uoc cua {1}", num1, num2);
                }
            };
            delCal3?.Invoke(5, 15);
            Del_Calculator delCal4 = delegate(int a, int b) 
            {
                System.Console.WriteLine("{0} - {1} = {2}", a, b, (a-b));
            };
            delCal4?.Invoke(10, 5);

            Del_Logger delLog = null;
            devide(out delLog, 10, 0);
            
        }
    }
    class Calculator
    {
        public void add(int num1, int num2)
        {
            System.Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
        }
        public void multi(int num1, int num2)
        {
            System.Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1*num2));
        }
        public void testDelegate(Del_Calculator delParam)
        {
            System.Console.WriteLine("Nhap vao so 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Nhap vao so 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            delParam.Invoke(num1, num2);
        }
    }

    class ClassA
    {
        public int MethodA(int a, int b)
        {
            return a+b;
        }
    }
    class Logger
    {
        /*
        Hien thi chuoi mau xanh
        */
        public static void Info(String message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void Error(String message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void Warning(String message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine(message);
            Console.ResetColor();
        }
    }

}
