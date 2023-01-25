using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace sampleCode
{
    public class emp1
    {
        protected double bonnus, salary, netpaid;
        protected int id, count;
        protected string name;

        public emp1(string name, double salary)
        {
            count++;
            id = count;
            this.name = name;
            this.salary = salary;
        }
        public virtual void NetPaid()
        {
            bonnus = salary * 0.30;
            netpaid = salary + bonnus;
        }
        //ToString ->  Display string representation of an obect
        public override string ToString()
        {
            return $"Id {id} name {name} salary {salary} Net paid salary {netpaid}";


        }
    

        /*protected double hra, da, ta, pf,gross,basicS;
        protected int id,count;
        protected string name;

        public Company(string name,double basicS)
        {
            count++;
            id = count;
            //this.id = id;
            this.basicS = basicS;
            this.name = name;
        }
        public virtual void CalculateSalary()
        {
            hra = basicS * 0.40;
            da = basicS * 0.20;
            ta = basicS * 0.10;
            pf = basicS * 0.10;
            gross = (basicS + hra + da + ta) - pf ;
        }
        public string employeeDetail()
        {
            return $"Id {id}, Name {name} basic salary {basicS} Gross of Employee {gross}" ;
        }*/
    }

    public class SalesPerson : emp1
    {
        protected double commi,product_cost;
        
                                                // base keyword will call the base class constructor
        public SalesPerson(string name,double salary):base(name,salary)
        {

        }
        public override void NetPaid()
        {
            bonnus = salary * 0.25;
            commi = product_cost * 0.10;
            netpaid = salary + commi + bonnus;
        }
        public override string ToString()
        {
            return $"Id {id} name {name} salary {salary} Net paid salary {netpaid}";

        }

    }











    /*public class Manager : Company
    {
        private double food, ma;

        public Manager(string name , int basicS):base(name , basicS)
        {
                
        }
        public override void CalculateSalary()
        {
            hra = basicS * 0.40;
            da = basicS * 0.20;
            ta = basicS * 0.10;
            pf = basicS * 0.10;
            food = basicS * 0.05;
            ma = basicS * 0.12;
            gross = (basicS + hra + da + ta) - (pf + ma);

        }

        public string EmployeeDetails()
        {
            return $"Id {id}, Name {name} basic salary {basicS} Gross of Employee {gross}" ;
        }

    }*/

}
