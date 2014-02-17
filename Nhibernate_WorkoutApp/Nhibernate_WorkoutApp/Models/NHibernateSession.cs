using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Cfg;

namespace Nhibernate_WorkoutApp.Models
{
     public class NHibertnateSession
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            
            var configurationPath = 
                HttpContext.Current.Server.MapPath(@"~\Models\NHibernate\Configuration\hibernate.cfg.xml");
            
            configuration.Configure(configurationPath);
            
            var usersConfigurationFile =
                HttpContext.Current.Server.MapPath(@"~\Models\Nhibernate\Mappings\Users.hbm.xml");
            
            configuration.AddFile(usersConfigurationFile);
            
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            
            return sessionFactory.OpenSession();
        }
    }
}