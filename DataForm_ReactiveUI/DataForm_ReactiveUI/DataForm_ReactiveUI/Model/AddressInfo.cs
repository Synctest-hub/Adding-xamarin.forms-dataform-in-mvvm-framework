using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace DataForm_ReactiveUI
{
    public class AddressInfo
    {
        public string Name { get; set; }
        public string Address{ get; set; }
    }
 
    public class ContactInfo : ReactiveObject
    {
        private AddressInfo addressInfo;
        public AddressInfo AddressInfo
        {
            get => addressInfo;
            set => this.RaiseAndSetIfChanged(ref addressInfo, value);
        }

        public ContactInfo()
        {
            AddressInfo = new AddressInfo();
        }
    }
}
