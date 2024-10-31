using school_system.models;

namespace school_system.interfaces_repo
{
    public interface IRepositoryStudent
    {
        public List<students_Dot> ReturnAllStudent();
        public bool AddNewStudent(students_Dot students_Dot);
        public bool Login(student_Dot_login students_Dot);
        public bool DeleteStudent(int id);
    }
}
