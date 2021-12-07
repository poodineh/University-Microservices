using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using University.Courses.Core.Entities;

namespace University.Courses.Application
{
    public interface ICourseDbContext
    {
        DbSet<Course> Courses { get; set; }
        Task BeginTransactionAsync();
        Task CommitTransactionAsync(CancellationToken cancellationToken);
        Task RollbackTransaction(CancellationToken cancellationToken);
    }
}