using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ProjectTaskXAF.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Project : BaseObject
    { 
        public Project(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }


        Customer customer;
        Employee assignedTo;
        string projectName;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ProjectName
        {
            get => projectName;
            set => SetPropertyValue(nameof(ProjectName), ref projectName, value);
        }


        [Association("Employee-Projects")]
        public Employee AssignedTo
        {
            get => assignedTo;
            set => SetPropertyValue(nameof(AssignedTo), ref assignedTo, value);
        }

        [Association("Project-ProjectTasks")]
        public XPCollection<ProjectTask> ProjectTasks
        {
            get
            {
                return GetCollection<ProjectTask>(nameof(ProjectTasks));
            }
        }


        
        [Association("Customer-Projects")]
        public Customer Customer
        {
            get => customer;
            set => SetPropertyValue(nameof(Customer), ref customer, value);
        }
    }
}