using System;
using Microsoft.EntityFrameworkCore;

namespace Legacy.Persistency
{
    public class LegacyDatabase : DbContext
    {
        public LegacyDatabase(DbContextOptions options)
        : base(options)
        {
            
        }
}
}
