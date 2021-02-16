using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
  public interface IApplicationDbContext
  {


    DbSet<ExampleChild> ExampleChildren { get; set; }
    DbSet<ExampleParent> ExampleParents { get; set; }
    DbSet<TodoItem> TodoItems { get; set; }
    DbSet<User> Users { get; set; }
    DbSet<TodoList> TodoLists { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
  }
}
