using kingsmen.Models;
using Microsoft.EntityFrameworkCore;

namespace kingsmen.DAL
{
    public class CharacterContext : DbContext
    {

        public CharacterContext(DbContextOptions<CharacterContext> options)
            : base(options)
        {
        }


        public DbSet<Character> Characters { get; set; }
    }
}