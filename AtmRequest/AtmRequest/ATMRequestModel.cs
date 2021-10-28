using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AtmRequest
{
    enum RequestStatus
    {
        Pending,
        Reject,
        Completed
    }

    class ATMRequestModel //: INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;
        public string RequestTime { get; set; }

        public string Address { get; set; }

       public RequestStatus Status { get; set; }

       
    }
}
