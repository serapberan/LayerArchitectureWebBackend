using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.BaseEntities
{
    public class BaseEntity
    {
        public virtual bool IsDeleted { get; set; }
        public string Language { get; set; }

        public string Slug { get; set; }
    }
}
