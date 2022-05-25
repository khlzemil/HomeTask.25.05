using HomeWork._25._05;
using System;
namespace HomeWork._25._05 {
    class Program
    {

        public static void Main()
        {

            Console.WriteLine("Enter Username and Password: ");
            string userName = Console.ReadLine();
            string userPassword = Console.ReadLine();

            Student student1 = new Student()
            {
                Name = "Emil",
                Surname = "Quluzade",
                Username = "emilkhlz",
                Password = "emil123",
                Grade = "85",

            };
            Student student2 = new Student()
            {
                Name = "Tural",
                Surname = "Yusifov",
                Username = "turalyusif",
                Password = "tural321",
                Grade = "75"
            };
            Student student3 = new Student()
            {
                Name = "Seid",
                Surname = "Celilzade",
                Username = "saidcelil",
                Password = "said213",
                Grade = "90"
            };
            Student student4 = new Student()
            {
                Name = "Elnur",
                Surname = "Abiyev",
                Username = "abiyevelnur",
                Password = "abiyev231",
                Grade = "70"
            };
            User[] user = { student1, student2, student3, student4 };
           
            bool flag = false;

            foreach (var data in user)
            {
                if (userName == data.Username && userPassword == data.Password)
                {
                    flag = true;
                    data.IsUser();
                }
                
            }
            if (!flag)
            {
                Console.WriteLine("This username or password is valid");
            }


        }


    }
}