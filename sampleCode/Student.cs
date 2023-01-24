using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace sampleCode
{
    public class Student
    {
        private int rollno;
        private string name;
        private double percentage;
        private int eng, hin, maths, total;


        public Student()
        {
            rollno = 1;
            name = "sakshi";
            percentage = 60.25;
            eng = 0;
            hin = 0;
            maths= 0;
        }
        public Student(int rollno, string name,int eng,int hin,int maths)
        {
            this.rollno = rollno;
            this.name = name;
            this.eng = eng;
            this.hin = hin;
            this.maths = maths;
        }

       public void Calculation()
        {
            total=eng+hin+maths;
            percentage=(double) total/3;
        }
        public string Display()
        {
            return $"Roll no {rollno} name {name} total {total} percentage {percentage}";
        }
    }
}
