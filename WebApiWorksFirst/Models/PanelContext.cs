using Microsoft.EntityFrameworkCore;

namespace WebApiWorksFirst.Models;

public class PanelContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DLOP8P5\SQLEXPRESS;Initial Catalog=WebApiPanel;Integrated Security=True;Trust Server Certificate=True;");
    }

    public DbSet<AdminUser> AdminUsers { get; set; }
}
