using school_system.interfaces_repo;
using school_system.models;

namespace school_system.repos
{
    public class RepoSubject : IRepositorySubject
    {
        private readonly appdbcontext context_;
        public RepoSubject(appdbcontext context)
        {
            context_ = context;
        }
        public bool AddSubject(subject_Dot subject_Dot)
        {
            subjects subjects = new subjects { Name = subject_Dot.name };
            try
            {
                context_.subjects.Add(subjects);
                context_.SaveChanges();
                return true;
            }
            catch {  return false; }
        }
    }
}
