using _4.StudentsManagement_MVC_CodeFirst.DataAccess.BaseEntities;
using System;
using System.Collections.Generic;

namespace _4.StudentsManagement_MVC_CodeFirst.DataAccess.Entities
{
    public class Lecture : BaseEntity
    {
        public bool OnBoard { get; set; }
        public List<ClassRoomLectures> ClassRoomLectures { get; set; }
    }
}
