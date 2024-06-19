using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCarServer.Core.Data.Abstract
{
    public class Entity : IEntity
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public Entity()
        {
            DateCreated = DateTime.UtcNow;
        }
    }
}
