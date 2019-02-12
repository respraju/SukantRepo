using Hiwarcom.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiwarcom.Infrastructure
{
    public class MainDataContextDataContextInitializer : DropCreateDatabaseAlways<MainDataContext>
    {
        protected override void Seed(MainDataContext context)
        {
            User user = new User() { Name = "ranjeet", EmailID = "respraju@gmail.com", Password = "123456", MobileNumber = "931-331-7580" };

            context.Users.Add(user);


            context.SaveChanges();

            base.Seed(context);
        }
    }
}
