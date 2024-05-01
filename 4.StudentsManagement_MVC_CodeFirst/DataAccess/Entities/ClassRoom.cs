using System.Collections.Generic;

namespace _4.StudentsManagement_MVC_CodeFirst.DataAccess.Entities
{
    public class ClassRoom
    {
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassDescriptions { get; set; }
        public List<ClassRoomLectures> ClassRoomLectures { get; set; }
        public List<ClassRoomStudents> ClassRoomStudents { get; set; }
    }
}
