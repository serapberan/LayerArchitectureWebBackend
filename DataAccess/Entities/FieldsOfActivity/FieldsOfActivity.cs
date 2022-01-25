using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.FieldsOfActivity
{
    public class FieldsOfActivity :BaseEntities.BaseEntity, IEntities
    {
        public int Id { get; set; }
        public String Image { get; set; }
        public String ImageName { get; set; }
        public String ImageType { get; set; }
        public String Title { get; set; }


    }
}
