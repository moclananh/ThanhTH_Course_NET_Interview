using _4.StudentsManagement_MVC_CodeFirst.DataAccess.BaseEntities;
using System;
using System.Collections.Generic;

namespace _4.StudentsManagement_MVC_CodeFirst.DataAccess.Entities
{
    public class Student : BaseEntity
    {
        public float GPA { get; set; }
        public List<ClassRoomStudents> ClassRoomStudents { get; set; }

    }
}
