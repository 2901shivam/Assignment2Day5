using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentsGrades = new ArrayList() {85,92,78,95};

            int sum = 0;
            //foreach(var items in studentsGrades)
            //{
            //    Console.WriteLine(items+"\t");

            //}
            Console.WriteLine("Student grades as follows");
            for (int i = 0; i < studentsGrades.Count; i++)
            {
                sum = sum +(int)studentsGrades[i];
                Console.WriteLine(studentsGrades[i]);
            }
            Console.WriteLine("Sum of all the grades \t"+sum);
            //Grade addition
            studentsGrades.Add(90);

            Console.WriteLine("Updated contect after addition");

            foreach(var item in studentsGrades)
            {
                Console.WriteLine(item);
            }
            //Grade removal

            studentsGrades.Remove(78);

            Console.WriteLine("Updated content after removal");

            foreach(var item in studentsGrades)
            {
                Console.WriteLine(item); 
            }

            //Search and update;

            Console.WriteLine("Content after search and update");

            for (int i = 0; i < studentsGrades.Count; i++)
            {

                if ((int)studentsGrades[i] == 95)
                
                {
                    studentsGrades[i] = 96;
                }
            }
            foreach(var item in studentsGrades)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
