using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentManagementConsole
{
    public class Students
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double GPA { get; set;}
        public override string ToString()
        {
            return $"ID: {StudentId}, Name: {StudentName}, GPA: {GPA}, DOB: {DateOfBirth}";
        }
    }
    
}
