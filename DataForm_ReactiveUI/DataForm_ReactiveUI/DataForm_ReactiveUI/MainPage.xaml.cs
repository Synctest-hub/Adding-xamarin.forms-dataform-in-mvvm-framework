using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataForm_ReactiveUI
{
    public partial class MainPage : ContentPage, IViewFor<ContactInfo>
    {
        #region Constructor
        public MainPage()
        {
            InitializeComponent();
            ViewModel = new ContactInfo();
            this.Bind(ViewModel, x => x.AddressInfo, x => x.dataForm.DataObject);
        }
        #endregion

        #region ViewModel Setup

        public ContactInfo ViewModel
        {
            get;
            set;
        }
        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (ContactInfo)value; }
          
        }
        #endregion
    }
}
