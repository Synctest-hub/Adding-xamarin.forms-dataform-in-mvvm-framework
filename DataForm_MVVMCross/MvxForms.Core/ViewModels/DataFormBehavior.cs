using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MvxForms.Core.ViewModels
{
    public class DataFormBehavior : Behavior<ContentPage>
    {
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            var dataForm = bindable.FindByName<SfDataForm>("dataForm");
            dataForm.AutoGeneratingDataFormItem += DataForm_AutoGeneratingDataFormItem;
        }

        private void DataForm_AutoGeneratingDataFormItem(object sender, Syncfusion.XForms.DataForm.AutoGeneratingDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null && e.DataFormItem.Name == "Age")
            {
                e.DataFormItem.IsVisible = false;
            }
        }
    }
}
