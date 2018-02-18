using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResources.Model;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;

namespace HumanResources.Controller
{
    class Controller
    {
        private HumanResourcesEntities db = new HumanResourcesEntities();

        public Boolean Login(string Username, string Password)
        {
            ObjectParameter Message = new ObjectParameter("responseMessage", typeof(string));
            ObjectParameter IdAdmin = new ObjectParameter("idAdmin", typeof(int)); ;
            int loginQuery = db.PR_AdminLogin(Username, Password, Message, IdAdmin);
            return Message.Value.Equals("Success");
        }
    }
}
