using CourseManagement.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagement
{
    class Student
    {
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public StudentType StudentType { get; set; }
       
        public string GroupNo { get; set; }
    }
}
