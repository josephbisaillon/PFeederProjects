using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ElephantServer.UI
{
    public class UIControls : INotifyPropertyChanged
    {
        private string _consoleline;
        //private string _organization;

        public string ConsoleLine
        {
            get { return _consoleline; }
            set
            {
                _consoleline = value;
                RaisePropertyChanged("Name");
            }
        }

        //public string Organization
        //{
        //    get { return _organization; }
        //    set
        //    {
        //        _organization = value;
        //        RaisePropertyChanged("Organization");
        //    }
        //}


        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        } 
    }
}
