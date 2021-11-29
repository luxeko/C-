using System;
namespace Buoi5
{
    public class Nguoi
    {
        // biến
            //field
            string name;
            int age;
            string address;

            public Nguoi()
            {
            }
            public Nguoi(string name, int age, string address)
            {
                this.Name = name;
                this.Age = age;
                this.Address = address;
            }

            //properties
            public string Name { get => name; set => name = value; }
            public int Age { get => age; set => age = value; }
            public string Address { get => address; set => address = value; }


        // hàm: normal, static, virtual, abstract
            //normal
            // public void doWork()
            // {
            //     System.Console.WriteLine("Con nguoi song va lam viec co quy luat.");
            // }

            //virtual - hàm ảo: cho phép lớp con ghi đè lại hàm ảo của lớp cha
            public virtual void doWork()
            {
                System.Console.WriteLine("Con nguoi song va lam viec co quy luat.");
            }

            public virtual void input()
                {
                    System.Console.WriteLine("Name: ");
                    name = Console.ReadLine();
                    System.Console.WriteLine("Age:");
                    age = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Address:");
                    address = Console.ReadLine();
                }

            public override string ToString()
            {
                return "Name: " + name + "; age: " + age + "; address" + address;
            }
    }
}