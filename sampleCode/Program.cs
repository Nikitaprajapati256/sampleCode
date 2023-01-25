using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleCode
{
    public class Program
    { 
        //reference keyword
        /*static void Swap (ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = temp;
            temp = b;
        }
        // out keyword 
        static void Calc(int a,int b,out int sum,out int sub,out int mul)
        {
            sum = a + b;
            sub= a-b;
            mul = a*b;
        }*/
        static void Main(string[] args)
        {


            Circle c1 = new Circle(5);
            c1.CalculateArea();
            Console.WriteLine(c1);

            Rectangle r1= new Rectangle(6,12);
            r1.CalculateArea();
            Console.WriteLine(r1);


            /*int a = 10,b=20,sum,sub,mul;
            Swap(ref a, ref b);
            Console.WriteLine($"Value of a = {a} and b = {b}");

            Calc(a,b,out sum,out sub,out mul);
            Console.WriteLine($"sum={sum},sub={sub}, mul={mul}");*/




            //object of student calss
            /*Student stud = new Student();
            string result = stud.Display();
            Console.WriteLine(result);

            Student stud1 = new Student(101, "Nikita", 56.35);
            Console.WriteLine(stud1.Display());

            //creating object of class employee

            Employee emp = new Employee();
            Console.WriteLine(emp.Display());
            Employee emp2= new Employee(102,"Bhakti",40000);
            Console.WriteLine(emp2.Display());

            
            // creating object of class book

            Book bk = new Book();
            Console.WriteLine(bk.Display());
            Book bk2 = new Book("A.P.J.Abdul kalam", "Wings of Fire", 500);
            Console.WriteLine(bk2.Display());*/

            /*Student stud=new Student(101,"sakshi",78,68,87);
            stud.Calculation();
            Console.WriteLine(stud.Display());


            Employee emp=new Employee(102,"xyz",5000);
            emp.CalSalary();
            Console.WriteLine(emp.Display());*/

            //object of class product
            /*
            Product prd = new Product();
            prd.Discount();
            Console.WriteLine(prd.Display());

            Product prd1= new Product(103,"fan",1500);
            prd1.Discount();
            Console.WriteLine(prd1.Display());*/

            /*Employee ep1 = new Employee("xyz",30000);
            Employee ep2 = new Employee("abc", 40000);
            Employee ep3 = new Employee("ijk", 20000);
            Console.WriteLine(ep1.print());
            Console.WriteLine(ep2.print());
            Console.WriteLine(ep3.print());

            Console.WriteLine($"Total object of class {Employee.DisplayCount()}");*/

            // object of class employee

            /*  Employee e1= new Employee();
              e1.Id = 1000;
              e1.Name = "ABC ";
              e1.Age = 25;
              Console.WriteLine($"{e1.Id} {e1.Name} {e1.Age}");*/

            // object of class product

            /*Product p1=new Product();
            p1.Pid = 1001;
            p1.Name = "AC";
            p1.Price= 25000;

            Console.WriteLine($"{p1.Pid} {p1.Name} {p1.Price}");*/

            // metthod overloading ... object of class calculate

            //Calculate cl= new Calculate();
            //Console.WriteLine(cl.Addition(52.36,62.12));
            //Console.WriteLine(cl.Addition(25,65));
            //Console.WriteLine(cl.Addition(45,32.12,40.2F));


            // overriding and inheritance object of class company

            //Manager m1 = new Manager("Varsha", 10000);
            //m1.CalculateSalary();
            //Console.WriteLine(m1.EmployeeDetails());

            //object of salesperson class
            /* SalesPerson sq1 = new SalesPerson("ABCS",30000);
             sq1.NetPaid();
             Console.WriteLine(sq1);

             //object of class emp1
             emp1 c1 = new emp1("XYZ",30000);
             c1.NetPaid();
             Console.WriteLine(c1.ToString());*/








        }
    }
}
 