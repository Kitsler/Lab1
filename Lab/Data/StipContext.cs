using Lab.Data;
using Microsoft.EntityFrameworkCore;


namespace Lab.Data;
public class StipContext : DbContext
{
		public StipContext(DbContextOptions<StipContext> options)
		: base(options){

		}
 protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
 // this property isn't on the C# class
 // so we set it up as a "shadow" property and use it for concurrency
		base.OnModelCreating(modelBuilder);
	}

 public DbSet<Student> students { get; set; }

 public DbSet<Stipendia> stipendias { get; set; }

 public override void Dispose()
	{
		base.Dispose();
	}


 public override ValueTask DisposeAsync()
	{
		return base.DisposeAsync();
	}
}
