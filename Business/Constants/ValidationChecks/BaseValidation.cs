using Business.Constants.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.ValidationChecks
{
    public class BaseValidation
    {
        public void IsExists(dynamic obj)
        {
            if (obj == null)
            {
                throw new Exception(ExceptionMessages.DoesntExist);
            }
        }

        public void IsDeleted(dynamic obj)
        {
            if (obj.IsDeleted)
            {
                throw new Exception(ExceptionMessages.AlreadyDeleted);
            }
        }
    }
}
