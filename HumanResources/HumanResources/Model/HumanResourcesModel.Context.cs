﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HumanResources.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HumanResourcesEntities : DbContext
    {
        public HumanResourcesEntities()
            : base("name=HumanResourcesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int PR_AddPayment(Nullable<int> idEmployee, Nullable<decimal> amount, string description, Nullable<System.DateTime> date, ObjectParameter responseMessage)
        {
            var idEmployeeParameter = idEmployee.HasValue ?
                new ObjectParameter("IdEmployee", idEmployee) :
                new ObjectParameter("IdEmployee", typeof(int));
    
            var amountParameter = amount.HasValue ?
                new ObjectParameter("Amount", amount) :
                new ObjectParameter("Amount", typeof(decimal));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PR_AddPayment", idEmployeeParameter, amountParameter, descriptionParameter, dateParameter, responseMessage);
        }
    
        public virtual int PR_AddVacation(Nullable<int> idEmployee, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, ObjectParameter responseMessage)
        {
            var idEmployeeParameter = idEmployee.HasValue ?
                new ObjectParameter("IdEmployee", idEmployee) :
                new ObjectParameter("IdEmployee", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PR_AddVacation", idEmployeeParameter, startDateParameter, endDateParameter, responseMessage);
        }
    
        public virtual int PR_AdminLogin(string username, string password, ObjectParameter responseMessage, ObjectParameter idAdmin)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PR_AdminLogin", usernameParameter, passwordParameter, responseMessage, idAdmin);
        }
    
        public virtual int PR_CreateAdmin(string userName, string password, ObjectParameter responseMessage)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PR_CreateAdmin", userNameParameter, passwordParameter, responseMessage);
        }
    
        public virtual int PR_CreateEmployee(Nullable<decimal> identification, string name, string lastname, string email, string phone, string gender, string maritalState, string adress, Nullable<System.DateTime> birthdate, Nullable<System.DateTime> hireDate, string title, Nullable<decimal> salary, ObjectParameter responseMessage)
        {
            var identificationParameter = identification.HasValue ?
                new ObjectParameter("Identification", identification) :
                new ObjectParameter("Identification", typeof(decimal));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var lastnameParameter = lastname != null ?
                new ObjectParameter("Lastname", lastname) :
                new ObjectParameter("Lastname", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var maritalStateParameter = maritalState != null ?
                new ObjectParameter("MaritalState", maritalState) :
                new ObjectParameter("MaritalState", typeof(string));
    
            var adressParameter = adress != null ?
                new ObjectParameter("Adress", adress) :
                new ObjectParameter("Adress", typeof(string));
    
            var birthdateParameter = birthdate.HasValue ?
                new ObjectParameter("Birthdate", birthdate) :
                new ObjectParameter("Birthdate", typeof(System.DateTime));
    
            var hireDateParameter = hireDate.HasValue ?
                new ObjectParameter("HireDate", hireDate) :
                new ObjectParameter("HireDate", typeof(System.DateTime));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("Salary", salary) :
                new ObjectParameter("Salary", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PR_CreateEmployee", identificationParameter, nameParameter, lastnameParameter, emailParameter, phoneParameter, genderParameter, maritalStateParameter, adressParameter, birthdateParameter, hireDateParameter, titleParameter, salaryParameter, responseMessage);
        }
    
        public virtual int PR_UpdateEmployee(Nullable<decimal> identification, string name, string lastname, string email, string phone, string gender, string maritalState, string adress, Nullable<System.DateTime> birthdate, Nullable<System.DateTime> hireDate, string title, Nullable<decimal> salary, ObjectParameter responseMessage)
        {
            var identificationParameter = identification.HasValue ?
                new ObjectParameter("Identification", identification) :
                new ObjectParameter("Identification", typeof(decimal));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var lastnameParameter = lastname != null ?
                new ObjectParameter("Lastname", lastname) :
                new ObjectParameter("Lastname", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var maritalStateParameter = maritalState != null ?
                new ObjectParameter("MaritalState", maritalState) :
                new ObjectParameter("MaritalState", typeof(string));
    
            var adressParameter = adress != null ?
                new ObjectParameter("Adress", adress) :
                new ObjectParameter("Adress", typeof(string));
    
            var birthdateParameter = birthdate.HasValue ?
                new ObjectParameter("Birthdate", birthdate) :
                new ObjectParameter("Birthdate", typeof(System.DateTime));
    
            var hireDateParameter = hireDate.HasValue ?
                new ObjectParameter("HireDate", hireDate) :
                new ObjectParameter("HireDate", typeof(System.DateTime));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("Salary", salary) :
                new ObjectParameter("Salary", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PR_UpdateEmployee", identificationParameter, nameParameter, lastnameParameter, emailParameter, phoneParameter, genderParameter, maritalStateParameter, adressParameter, birthdateParameter, hireDateParameter, titleParameter, salaryParameter, responseMessage);
        }
    
        public virtual ObjectResult<PR_ViewEmployees_Result> PR_ViewEmployees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PR_ViewEmployees_Result>("PR_ViewEmployees");
        }
    }
}
