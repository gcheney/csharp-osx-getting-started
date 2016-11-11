using System;
using System.Collections.Generic;

namespace ScopeAccessibility
{
    public class Course
    {
        private string _name;
        private List<Student> _students;

        public Course (string name, List<Student> students) 
        {
            _name = name;
            _students = students;
        }

        public string GetCourseName() 
        {
            return _name;
        }

        public List<string> GetAdultStudentNames()
        {
            var studentNames = new List<string>();
            _students
                .FindAll(s => s.IsAnAdult())
                .ForEach(s => studentNames.Add(s.RosterName));
                
            return studentNames;
        }
    }
}
