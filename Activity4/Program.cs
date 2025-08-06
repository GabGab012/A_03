using System;

namespace Activity4
{
    abstract class Student
    {
        protected string name;
        protected double grade;
        public void SetData(string name, double grade)
        {
            this.name = name;
            this.grade = grade;
        }
        public abstract void DisplayInfo();
        public abstract void CheckStatus();
    }
    class College : Student
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"College Student Name: {name}");
            Console.WriteLine($"Grade: {grade}");
        }
        public override void CheckStatus()
        {
            if (grade >= 3.0)
            {
                Console.WriteLine($"Grade Status: PASSED");
                return;
            }
            else
            {
                Console.WriteLine($"Grade Status: FAILED");
            }
        }
    }
    class SeniorHigh : Student
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Senior High Student Name: {name}");
            Console.WriteLine($"Grade: {grade}");
        }
        public override void CheckStatus()
        {
            if (grade >= 75)
            {
                Console.WriteLine($"Grade Status: PASSED");
                return;
            }
            else
            {
                Console.WriteLine($"Grade Status: FAILED");
            }
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Student cc1 = new College();
            cc1.SetData("Brandog", 4.0);
            cc1.DisplayInfo();
            cc1.CheckStatus();

            Student cc2 = new College();
            cc2.SetData("Bamie", 2.5);
            cc2.DisplayInfo();
            cc2.CheckStatus();

            Student shs1 = new SeniorHigh();
            shs1.SetData("David", 93);
            shs1.DisplayInfo();
            shs1.CheckStatus();

           Student shs2 = new SeniorHigh();
            shs2.SetData("Eubert", 74);
            shs2.DisplayInfo();
            shs2.CheckStatus();
        }
    }
}
