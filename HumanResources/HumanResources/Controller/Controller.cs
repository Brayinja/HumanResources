using System;
using HumanResources.Model;
using System.Data.Entity.Core.Objects;
using System.Collections.Generic;

namespace HumanResources.Controller
{
    class Controller
    {
        public HumanResourcesEntities db = new HumanResourcesEntities();

        public Boolean Login(string Username, string Password)
        {
            ObjectParameter Message = new ObjectParameter("responseMessage", typeof(string));
            ObjectParameter IdAdmin = new ObjectParameter("idAdmin", typeof(int));
            int loginQuery = db.PR_AdminLogin(Username, Password, Message, IdAdmin);
            return Message.Value.Equals("Success");
        }

        public ObjectResult<PR_ViewEmployees_Result> getEmployees()
        {
            return db.PR_ViewEmployees();
        }
    }
}
