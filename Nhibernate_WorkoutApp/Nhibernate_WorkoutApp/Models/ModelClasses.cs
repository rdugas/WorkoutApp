using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nhibernate_WorkoutApp.Models
{
    public class Users
    {
        public virtual int Userid { get; set; }
        public virtual string UserName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime Birthdate { get; set; }
    }
}