using System.Data.Entity;
using Lychee.Entities.Entities;

namespace Lychee.Entities
{
    public abstract class LycheeContext : DbContext
    {
        protected LycheeContext(string connectionString) : base(connectionString)
        {

        }

        public virtual IDbSet<Setting> Settings { get; set; }
    }
}
