using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using ProjectTaskXAF.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTaskXAF.Module.Controllers
{
    public class TasksCompletedController : ViewController
    {

        SimpleAction Complete;

        public TasksCompletedController()
        {
            TargetObjectType = typeof(ProjectTask);

            Complete = new SimpleAction(this, "Complete", PredefinedCategory.Edit);
            Complete.SelectionDependencyType = SelectionDependencyType.RequireSingleObject;
            Complete.Execute += Complete_Execute;
        }

        private void Complete_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var currentObj = e.CurrentObject as ProjectTask;
            if (currentObj != null)
            {
                currentObj.Status = Status.Completed;
            }

            if (this.ObjectSpace.IsModified)
            {
                this.ObjectSpace.CommitChanges();
            }
        }

        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
    }
}
