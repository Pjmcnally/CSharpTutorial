using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> info = GetStudentInformation();
            PrintStudentDetails(info);
        }

        static List<string> GetStudentInformation()
        {
            List<string> studentInfo = new List<string>();

            Console.WriteLine("Enter the student's first name: ");
            studentInfo.Add(Console.ReadLine());
            Console.WriteLine("Enter the student's last name");
            studentInfo.Add(Console.ReadLine());
            Console.WriteLine("Enter the student's date of birth");
            studentInfo.Add(Console.ReadLine());

            return studentInfo;
        }

        static void PrintStudentDetails(List<string> studentInfo)
        {
            Console.WriteLine("{0} {1} was born on: {2}", studentInfo[0], studentInfo[1], studentInfo[2]);
        }
    }
}
