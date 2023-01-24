using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace sampleCode
{
    
    
    public class Employee
    {


        //property 
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }


        /*private int id;
        private string name;
        private int age;

        public int Id
        {
            get{ return id; } 
            set { id = value; }
            
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        { get { return age; } 
          set {age= value; } 
        }*/

        /*private static int count;
        private static string companyName;
        private string empName;
        private int empId,salary;


        static Employee()
        {
            companyName = "TCS";

        }
        public Employee(string empName,int salary)
        {
            this.empName = empName;
            this.salary = salary;
            empId = count;
            count++;
            

        }
        public static int DisplayCount()
        {
            return count;
        }
        public string print()
        {
            return $"employee Id {empId} Employee Name {empName} Company Name {companyName} salary {salary}";
        }
        */





        //private int emp_id;
        //private string emp_name;
        //private double basic_salary,total,net_paid;

        /* public Employee()
         {
             emp_id= 100;
             emp_name = "Saurabh";
             basic_salary = 50000;
         }
         public Employee(int emp_id, string emp_name, double basic_salary)
         {
            this.emp_id= emp_id;
             this.emp_name= emp_name;
             this.basic_salary= basic_salary;

         }
         public void CalSalary()
         {
             double hra = basic_salary * 0.40;
             double da = basic_salary * 0.20;
             double pf = basic_salary * 0.12;
             double pt = 200;

              total= basic_salary+hra+ da ;
              net_paid = total - (pf + pt);

         }

         public string Display()
         {
             return $"employee Id - {emp_id} employee name - {emp_name} salary - {basic_salary} totat salary {total} and net paid salary {net_paid} ";
         } */
    }
}
