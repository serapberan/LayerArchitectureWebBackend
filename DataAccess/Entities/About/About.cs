using DataAccess.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.About
{
    public class About: BaseEntity, IEntities
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required] //Girilmesi zorunlu olması için
        public String Title { get; set; }

        [Required]
        public String Description { get; set; }
        public string ImageName { get; set; }


        [StringLength(5)]
        public string ImageType { get; set; }


        public string Image { get; set; }



    }
}
