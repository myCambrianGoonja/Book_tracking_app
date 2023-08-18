using Microsoft.EntityFrameworkCore;
using Book_tracking_app.Models.Entities;

namespace Book_tracking_app.Database
{

    public class BookCategoryContext : DbContext
    {
        public BookCategoryContext(DbContextOptions<BookCategoryContext> options)
            : base(options)
        { }
        public DbSet<Books> Books => Set<Books>();
        public DbSet<Categories> Categories => Set<Categories>();
        public DbSet<Category_Type> Category_Type => Set<Category_Type>();

    }

}