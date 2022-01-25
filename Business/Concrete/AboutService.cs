using Business.Abstract;
using Business.Constants.ValidationChecks;
using DataAccess;
using DataAccess.Entities.About;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AboutService : BaseValidation,IAboutService
    {
        private readonly IRepository<About> _aboutRepository;

        public AboutService(IRepository<About> aboutRepository)
        {
            _aboutRepository = aboutRepository; 
        }
        public void Create(About about, IFormFile image)
        {
            var entity = new About();
            entity.Title = about.Title; 
            entity.Description = about.Description;

            if (image != null && image.Length > 0)
            {
                string imageType = Path.GetExtension(image.FileName);
                var imageName = String.Concat(DateTime.Now.Millisecond.ToString(), "-", image.FileName);
                var saveimg = Path.Combine("wwwroot", "UpLoads/About", imageName);
                var dbimg = Path.Combine("Uploads/About", imageName);
                var stream = new FileStream(saveimg, FileMode.Create);
                image.CopyTo(stream);   
                entity.ImageName= imageName;
                entity.ImageType= imageType;
                entity.Image = dbimg;

            }
            _aboutRepository.Create(entity); 
        }

        public void Delete(int id)
        {
            var entity = _aboutRepository.GetById(id);
            IsExists(entity);

            IsDeleted(entity);
            entity.IsDeleted = true;
            _aboutRepository.Update(entity);
        }

        public IList<About> GetAbout()
        {
            return _aboutRepository.GetList(f => !f.IsDeleted);
        }

        public About GetAboutByCode(string code)
        {
            return _aboutRepository.Get(f => f.Language == code && !f.IsDeleted);
        }

        public IList<About> GetAboutListByCode(string code)
        {
            throw new NotImplementedException();
        }

        public About GetById(int id)
        {
            var entity = _aboutRepository.GetById(id);
            IsExists(entity);

            IsDeleted(entity);
            return entity;
        }

        public void Update(About about, IFormFile image)
        {
            throw new NotImplementedException();
        }
    }
}
