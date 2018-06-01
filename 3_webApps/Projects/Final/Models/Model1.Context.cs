﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DB_122058_test2Entities1 : DbContext
    {
        public DB_122058_test2Entities1()
            : base("name=DB_122058_test2Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<LoginRequest> LoginRequests { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<vClass> vClasses { get; set; }
        public virtual DbSet<vClassStudent> vClassStudents { get; set; }
        public virtual DbSet<vLoginRequest> vLoginRequests { get; set; }
        public virtual DbSet<vStudent> vStudents { get; set; }
    
        public virtual int pDelClassStudents(Nullable<int> classId, Nullable<int> studentId)
        {
            var classIdParameter = classId.HasValue ?
                new ObjectParameter("ClassId", classId) :
                new ObjectParameter("ClassId", typeof(int));
    
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pDelClassStudents", classIdParameter, studentIdParameter);
        }
    
        public virtual int pDelLogins()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pDelLogins");
        }
    
        public virtual int pInsClassStudents(Nullable<int> classId, Nullable<int> studentId)
        {
            var classIdParameter = classId.HasValue ?
                new ObjectParameter("ClassId", classId) :
                new ObjectParameter("ClassId", typeof(int));
    
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pInsClassStudents", classIdParameter, studentIdParameter);
        }
    
        public virtual int pInsLoginRequest(string name, string emailAddress, string loginName, string newOrReactivate, string reasonForAccess, Nullable<System.DateTime> dateNeededBy)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var emailAddressParameter = emailAddress != null ?
                new ObjectParameter("EmailAddress", emailAddress) :
                new ObjectParameter("EmailAddress", typeof(string));
    
            var loginNameParameter = loginName != null ?
                new ObjectParameter("LoginName", loginName) :
                new ObjectParameter("LoginName", typeof(string));
    
            var newOrReactivateParameter = newOrReactivate != null ?
                new ObjectParameter("NewOrReactivate", newOrReactivate) :
                new ObjectParameter("NewOrReactivate", typeof(string));
    
            var reasonForAccessParameter = reasonForAccess != null ?
                new ObjectParameter("ReasonForAccess", reasonForAccess) :
                new ObjectParameter("ReasonForAccess", typeof(string));
    
            var dateNeededByParameter = dateNeededBy.HasValue ?
                new ObjectParameter("DateNeededBy", dateNeededBy) :
                new ObjectParameter("DateNeededBy", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pInsLoginRequest", nameParameter, emailAddressParameter, loginNameParameter, newOrReactivateParameter, reasonForAccessParameter, dateNeededByParameter);
        }
    
        public virtual int pInsLogins(string name, string emailAddress, string loginName, string reasonForAccess)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var emailAddressParameter = emailAddress != null ?
                new ObjectParameter("EmailAddress", emailAddress) :
                new ObjectParameter("EmailAddress", typeof(string));
    
            var loginNameParameter = loginName != null ?
                new ObjectParameter("LoginName", loginName) :
                new ObjectParameter("LoginName", typeof(string));
    
            var reasonForAccessParameter = reasonForAccess != null ?
                new ObjectParameter("ReasonForAccess", reasonForAccess) :
                new ObjectParameter("ReasonForAccess", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pInsLogins", nameParameter, emailAddressParameter, loginNameParameter, reasonForAccessParameter);
        }
    
        public virtual ObjectResult<pSelClassesByStudentID_Result> pSelClassesByStudentID(Nullable<int> studentId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pSelClassesByStudentID_Result>("pSelClassesByStudentID", studentIdParameter);
        }
    
        public virtual ObjectResult<pSelClassesByStudents_Result> pSelClassesByStudents()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pSelClassesByStudents_Result>("pSelClassesByStudents");
        }
    
        public virtual int pSelLoginIdByLoginAndPassword(string studentLogin, string studentPassword, ObjectParameter studentId)
        {
            var studentLoginParameter = studentLogin != null ?
                new ObjectParameter("StudentLogin", studentLogin) :
                new ObjectParameter("StudentLogin", typeof(string));
    
            var studentPasswordParameter = studentPassword != null ?
                new ObjectParameter("StudentPassword", studentPassword) :
                new ObjectParameter("StudentPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pSelLoginIdByLoginAndPassword", studentLoginParameter, studentPasswordParameter, studentId);
        }
    
        public virtual int pUpdClassStudents(Nullable<int> originalClassId, Nullable<int> originalStudentId, Nullable<int> newClassId, Nullable<int> newStudentId)
        {
            var originalClassIdParameter = originalClassId.HasValue ?
                new ObjectParameter("OriginalClassId", originalClassId) :
                new ObjectParameter("OriginalClassId", typeof(int));
    
            var originalStudentIdParameter = originalStudentId.HasValue ?
                new ObjectParameter("OriginalStudentId", originalStudentId) :
                new ObjectParameter("OriginalStudentId", typeof(int));
    
            var newClassIdParameter = newClassId.HasValue ?
                new ObjectParameter("NewClassId", newClassId) :
                new ObjectParameter("NewClassId", typeof(int));
    
            var newStudentIdParameter = newStudentId.HasValue ?
                new ObjectParameter("NewStudentId", newStudentId) :
                new ObjectParameter("NewStudentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pUpdClassStudents", originalClassIdParameter, originalStudentIdParameter, newClassIdParameter, newStudentIdParameter);
        }
    
        public virtual int pInsStudents(string studentName, string studentEmail, string studentLogin, string studentPassword)
        {
            var studentNameParameter = studentName != null ?
                new ObjectParameter("StudentName", studentName) :
                new ObjectParameter("StudentName", typeof(string));
    
            var studentEmailParameter = studentEmail != null ?
                new ObjectParameter("StudentEmail", studentEmail) :
                new ObjectParameter("StudentEmail", typeof(string));
    
            var studentLoginParameter = studentLogin != null ?
                new ObjectParameter("StudentLogin", studentLogin) :
                new ObjectParameter("StudentLogin", typeof(string));
    
            var studentPasswordParameter = studentPassword != null ?
                new ObjectParameter("StudentPassword", studentPassword) :
                new ObjectParameter("StudentPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pInsStudents", studentNameParameter, studentEmailParameter, studentLoginParameter, studentPasswordParameter);
        }
    }
}
