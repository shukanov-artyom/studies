using System;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace hwnn.Models
{
    public class ContosoContext : DbContext
    {
        public ContosoContext(DbContextOptions<ContosoContext> options)
            : base(options)
        {
            
        }                
    } 
}