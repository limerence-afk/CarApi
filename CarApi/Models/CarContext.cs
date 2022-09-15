using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace CarApi.Models
{ 
    public class CarContext :DbContext 
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; } = null!;
    }
}
