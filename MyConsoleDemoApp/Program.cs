using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleDemoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            foreach (Employee e in p.AllUsers())
            {
                Console.WriteLine(e.Name);
            }
            
            Console.ReadKey();
            
        }

        public string Login(string UserId, string Password)
        {
            if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(Password))
            {
                return "Userid or password could not be Empty.";
            }
            else
            {
                if (UserId == "Admin" && Password == "Admin")
                {
                    return "Welcome Admin.";
                }
                return "Incorrect UserId or Password.";
            }
        }
        public List<Employee> AllUsers()
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee
            {
                id = 100,
                Name = "Bharat",
                Gender = "male",
                salary = 40000
            });
            li.Add(new Employee
            {
                id = 101,
                Name = "sunita",
                Gender = "Female",
                salary = 50000
            });
            li.Add(new Employee
            {
                id = 103,
                Name = "Karan",
                Gender = "male",
                salary = 40000
            });
            li.Add(new Employee
            {
                id = 104,
                Name = "Jeetu",
                Gender = "male",
                salary = 23000
            });
            li.Add(new Employee
            {
                id = 105,
                Name = "Manasi",
                Gender = "Female",
                salary = 80000
            });
            li.Add(new Employee
            {
                id = 106,
                Name = "Ranjit",
                Gender = "male",
                salary = 670000
            });
            return li;
        }
        public List<Employee> getDetails(int id)
        {
            List<Employee> li1 = new List<Employee>();
            Program p = new Program();
            var li = p.AllUsers();
            foreach (var x in li)
            {
                if (x.id == id)
                {
                    li1.Add(x);
                }
            }
            return li1;
        }
    }
}
