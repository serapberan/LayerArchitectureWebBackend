using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Contact
{
    public class Contact: BaseEntities.BaseEntity ,IEntities
    {
        public int Id { get; set; }
        public String Title { get; set; }

        [StringLength(2000)]
        public String AddressArea { get; set; }
        //public String MapLink { get; set; }

        [DataType(DataType.EmailAddress)]
        public String Mail { get; set; }
        public String Tel { get; set; }
    }
}
