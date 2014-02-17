using System.Web.Mvc;
using NHibernate;
using NHibernate.Linq;
using System.Linq;
using Nhibernate_WorkoutApp.Models;

namespace Nhibernate_WorkoutApp.Controllers
{
    public class UsersController : Controller
    {

        public ActionResult Index()
        {
            using (ISession session = NHibertnateSession.OpenSession())
            {
                var users = session.Query<Users>().ToList();
                return View(users);
            }

        }
    }
}