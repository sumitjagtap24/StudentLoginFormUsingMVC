﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentLogin
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class enexionEntities : DbContext
    {
        public enexionEntities()
            : base("name=enexionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Student> Students { get; set; }
    
        public virtual int InsertStudent(string name, Nullable<System.DateTime> dOB, string email, string gender, string lang)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var dOBParameter = dOB.HasValue ?
                new ObjectParameter("DOB", dOB) :
                new ObjectParameter("DOB", typeof(System.DateTime));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var langParameter = lang != null ?
                new ObjectParameter("Lang", lang) :
                new ObjectParameter("Lang", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertStudent", nameParameter, dOBParameter, emailParameter, genderParameter, langParameter);
        }
    
        public virtual ObjectResult<Student> StudentLogin(string name, Nullable<System.DateTime> dOB, string email, string gender, string lang)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var dOBParameter = dOB.HasValue ?
                new ObjectParameter("DOB", dOB) :
                new ObjectParameter("DOB", typeof(System.DateTime));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var langParameter = lang != null ?
                new ObjectParameter("Lang", lang) :
                new ObjectParameter("Lang", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Student>("StudentLogin", nameParameter, dOBParameter, emailParameter, genderParameter, langParameter);
        }
    
        public virtual ObjectResult<Student> StudentLogin(string name, Nullable<System.DateTime> dOB, string email, string gender, string lang, MergeOption mergeOption)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var dOBParameter = dOB.HasValue ?
                new ObjectParameter("DOB", dOB) :
                new ObjectParameter("DOB", typeof(System.DateTime));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var langParameter = lang != null ?
                new ObjectParameter("Lang", lang) :
                new ObjectParameter("Lang", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Student>("StudentLogin", mergeOption, nameParameter, dOBParameter, emailParameter, genderParameter, langParameter);
        }

    //    internal void InsertStudent(string name, string email, string gender, DateTime dOB, string lang)
    //    {
    //        //throw new NotImplementedException();
    //    }

    //    internal void InsertStudent(string name, string email, DateTime dOB, string gender, string lang)
    //    {
    //        throw new NotImplementedException();
    //    }
    }
}