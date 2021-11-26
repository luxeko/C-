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
            public void doWork()
            {
                System.Console.WriteLine("Con nguoi song va lam viec co quy luat.");
            }

            

            
    }
}