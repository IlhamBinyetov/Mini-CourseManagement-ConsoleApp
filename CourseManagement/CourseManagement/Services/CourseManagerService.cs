using CourseManagement.Enums;
using CourseManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseManagement.Services
{
    class CourseManagerService : ICourseManagerService
    {
        List<Group> groups = new List<Group>();
        List<Student> students = new List<Student>();
        public void AddGroup(int groupNo, bool isOnline, string groupType)
        {
                Group newGroup = new Group(groupNo, groupType)
                {
                   
                    GroupType = groupType,
                    IsOnline = isOnline,
                    Limit = isOnline ? 15 : 10
                };
                groups.Add(newGroup);
        }


        public void AddStudent(string name, string surName, string groupNo, StudentType studentType)
        {
            var searchedStudent = students.FirstOrDefault(st => st.Name == name);

            if (searchedStudent == null)
            {
                Student student = new Student()
                {
                    Name = name,
                    Surname = surName,
                    GroupNo = groupNo,
                    StudentType = studentType
                };

                students.Add(student);
            }

          
        }

        public void EditGroup(string groupNo, string newGroupNo)
        {
            var existGroup = groups.FirstOrDefault(gr => gr.No == groupNo);
            if (existGroup != null)
            {
                existGroup.No = newGroupNo;
            }
        }
        
        public Group FindGroupByNo(string no)
        {
            var searchedGroup = groups.FirstOrDefault(sg => sg.No == no);
            return searchedGroup;
        }


        public List<Group> GetAllGroups()
        {
            return groups;
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public List<Student> GetStudentsByGroupNo(string groupNo)
        {
            List<Student> searchedStudents = students.Where(x => x.GroupNo == groupNo).ToList();
          
            return searchedStudents;
        }

        public List<Student> SearchStudents(string search)
        {
            List<Student> searchedStudents = students.Where(x => x.Name.Contains(search)).ToList();

            return searchedStudents;
        }
    }
}
