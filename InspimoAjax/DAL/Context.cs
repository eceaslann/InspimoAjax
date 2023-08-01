using Microsoft.EntityFrameworkCore;

namespace InspimoAjax.DAL
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DESKTOP-RCI54VP; initial catalog= Ajax.Inspimo; integrated security= true");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
