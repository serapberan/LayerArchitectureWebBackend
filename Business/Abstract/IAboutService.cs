using DataAccess.Entities.About;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAboutService
    {
        void Create(About about, IFormFile image);
        IList<About> GetAbout();
        void Update(About about, IFormFile image);
        void Delete(int id);
        About GetById(int id);
        About GetAboutByCode(string code);
        IList<About> GetAboutListByCode(string code);


    }
}
