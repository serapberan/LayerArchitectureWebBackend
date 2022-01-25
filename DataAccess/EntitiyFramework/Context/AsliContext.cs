using DataAccess.Entities.About;
using DataAccess.Entities.Contact;
using DataAccess.Entities.Header;
using DataAccess.Entities.FieldsOfActivity;
using DataAccess.Entities.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntitiyFramework.Context
{
    public class AsliContext: IdentityDbContext<AdminUser>
    {
        public AsliContext(DbContextOptions<AsliContext> options) : base(options)
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public  DbSet<FieldsOfActivity> fieldsOfActivties { get; set; }
        public DbSet<HeaderAddress> HeaderAddresses { get; set; }

    }

}
