using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.BaseEntities
{
    public class BaseAttachmentEntity
    {
        public BaseAttachmentEntity()
        {
            this.InsertDate = DateTime.Now.Date;
            this.InsertTime = DateTime.Now.TimeOfDay;
        }

        public string Image { get; set; }
        public string ImageName { get; set; }
        public string ImageType { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime InsertDate { get; set; }
        public TimeSpan InsertTime { get; set; }
    }
}
