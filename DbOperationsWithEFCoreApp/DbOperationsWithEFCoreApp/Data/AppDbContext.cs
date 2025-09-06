using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)  
        {
        }
    }
}
