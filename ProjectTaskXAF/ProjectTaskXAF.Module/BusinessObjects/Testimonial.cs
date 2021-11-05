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
    [NavigationItem("Marketing")]
    public class Testimonial : BaseObject
    { 
        public Testimonial(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }


        Customer customer;
        string description;
        string caseStudy;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string CaseStudy
        {
            get => caseStudy;
            set => SetPropertyValue(nameof(CaseStudy), ref caseStudy, value);
        }


        [Size(SizeAttribute.Unlimited)]
        public string Description
        {
            get => description;
            set => SetPropertyValue(nameof(Description), ref description, value);
        }

        
        [Association("Customer-Testimonials")]
        public Customer Customer
        {
            get => customer;
            set => SetPropertyValue(nameof(Customer), ref customer, value);
        }
    }
}