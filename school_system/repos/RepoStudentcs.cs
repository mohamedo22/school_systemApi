using Microsoft.EntityFrameworkCore;
using school_system.interfaces_repo;
using school_system.models;

namespace school_system.repos
{
    public class RepoStudentcs : IRepositoryStudent
    {
        private readonly appdbcontext context_;

        public RepoStudentcs(appdbcontext context)
        {
            context_ = context;
        }

        public bool AddNewStudent(students_Dot students_Dot)
        {
            students student = new students { name = students_Dot.name , password = students_Dot.password , subjectId=students_Dot.subjectId , username = students_Dot.username };
            try
            {
                context_.students.Add(student);
                context_.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool DeleteStudent(int id)
        {
            students student = context_.students.First(i => i.Id == id);
            if (student != null)
            {
                context_.students.Remove(student);
                context_.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Login(student_Dot_login students_Dot)
        {
            try
            {
                students student_ = context_.students.First(i => i.username == students_Dot.username && i.password == students_Dot.password);
                if (student_ != null)
                {
                    return true;
                }
                return false;

            }
            catch
            {
                return false;
            }
        }

        public List<students_Dot> ReturnAllStudent()
        {
            var allStudent = context_.students.Include(i => i.subject).Select(i => new students_Dot { name = i.name , username = i.username , subjectName = i.subject.Name});
            return allStudent.ToList();
        }
    }
}
