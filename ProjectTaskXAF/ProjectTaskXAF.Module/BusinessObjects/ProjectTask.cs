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
    public class ProjectTask : BaseObject
    { 
        public ProjectTask(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            status = Status.ToDo;
        }


        Status status;
        DateTime endDate;
        DateTime startDate;
        string subject;
        Project projects;

        [Association("Project-ProjectTasks")]
        public Project Projects
        {
            get => projects;
            set => SetPropertyValue(nameof(Projects), ref projects, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Subject
        {
            get => subject;
            set => SetPropertyValue(nameof(Subject), ref subject, value);
        }


        public DateTime StartDate
        {
            get => startDate;
            set => SetPropertyValue(nameof(StartDate), ref startDate, value);
        }


        public DateTime EndDate
        {
            get => endDate;
            set => SetPropertyValue(nameof(EndDate), ref endDate, value);
        }

        
        public Status Status
        {
            get => status;
            set => SetPropertyValue(nameof(Status), ref status, value);
        }

    }

    public enum Status
    {
        ToDo = 0,
        InProgress = 1,
        Completed = 2,
        Deferred = 3
    }
}