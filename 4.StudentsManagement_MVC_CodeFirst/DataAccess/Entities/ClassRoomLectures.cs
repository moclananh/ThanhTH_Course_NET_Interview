namespace _4.StudentsManagement_MVC_CodeFirst.DataAccess.Entities
{
    public class ClassRoomLectures
    {
        public string ClassId { get; set; }
        public string LectureId { get; set; }
        public Lecture Lecture { get; set; }
        public ClassRoom ClassRoom { get; set; }
    }
}
