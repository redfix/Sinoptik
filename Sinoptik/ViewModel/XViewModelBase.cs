using System;
using System.ComponentModel;

namespace Sinoptik.ViewModel
{
    class XViewModelBase : INotifyPropertyChanged
    {
        
        public void RaisePropertyChanged(String propertyName)
        {
            if(PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs("propertyName"));
        }
        
        public event PropertyChangedEventHandler PropertyChanged = null;

    }
}
