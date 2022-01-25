using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Header
{
    public class HeaderAddress:BaseEntities.BaseEntity ,IEntities
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Mail { get; set; }
        public String Tel { get; set; }
        public String Address { get; set; }

        public string ImageName { get; set; }


        [StringLength(5)]
        public string ImageType { get; set; }
        public string Image { get; set; }
    }
}
