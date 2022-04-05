using CourseManagement.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagement
{
    class Group
    {
        public Group(int number, string type)
        {
            string firstLetter = type.Substring(0, 1);
            string groupName = firstLetter + number;
            No = groupName;
        }
        
        public string No { get; set; }
        public bool IsOnline { get; set; } = false;

        public int Limit { get; set; }
        public List<Student> Students { get; set; } 
        public string GroupType { get; set; }
    }
}
