using System;

namespace _4.StudentsManagement_MVC_CodeFirst.DataAccess.BaseEntities
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public int Status { get; set; }
    }
}
