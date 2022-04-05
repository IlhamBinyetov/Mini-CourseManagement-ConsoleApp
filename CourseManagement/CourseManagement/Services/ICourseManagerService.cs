using CourseManagement.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagement.Interfaces
{
    interface ICourseManagerService
    {
        List<Group> GetAllGroups();
        void AddGroup(int groupNo, bool isOnline, string groupType);

        void EditGroup(string groupNo,  string newGroupNo);

        void AddStudent(string name, string surName, string groupNo, StudentType studentType );

        List<Student> GetStudentsByGroupNo(string groupNo);

        List<Student> GetAllStudents();

        Group FindGroupByNo(string groupNo);

        List<Student> SearchStudents(string search);
        

    }
}
