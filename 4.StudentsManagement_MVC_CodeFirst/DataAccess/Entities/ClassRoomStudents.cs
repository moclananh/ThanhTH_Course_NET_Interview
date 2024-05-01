namespace _4.StudentsManagement_MVC_CodeFirst.DataAccess.Entities
{
    public class ClassRoomStudents
    {
        public string ClassId { get; set; }
        public string StudentId { get; set; }
        public Student Student { get; set; }
        public ClassRoom ClassRoom { get; set; }
    }
}
