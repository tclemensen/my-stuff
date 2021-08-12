using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_4._10___Student_Record
{
    class StudentReg
    {
        // StudentReg constructor that receives 5 parameters
        public StudentReg(string studentID, string studentName, decimal grade1, decimal grade2, decimal grade3)
        {
            ID = studentID;
            Name = studentName;
            Grade1 = grade1;
            Grade2 = grade2;
            Grade3 = grade3;
        }

        // Autoimplemented GET and SET 
        public string ID { get; set; }
        public decimal Grade1 { get; set; }
        public decimal Grade2 { get; set; }
        public decimal Grade3 { get; set; }
        public string Name { get; set; }      
    }
}
