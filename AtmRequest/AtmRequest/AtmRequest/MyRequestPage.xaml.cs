using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtmRequest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyRequestPage : ContentPage
    {
        public MyRequestPage()
        {
            InitializeComponent();

            var myRequestList = new List<ATMRequestModel>
            {
                new ATMRequestModel
                {
                    RequestTime = "24 Auguest 2021 at 12:35 PM",
                    Address = "No 74, Anna Salai, Guindy, Chennai - 600032, Opposite Guindy Police Station, Guindy Industrial Estate",
                    Status = RequestStatus.Pending
                },
                new ATMRequestModel
                {
                    RequestTime = "24 Auguest 2021 at 12:35 PM",
                    Address = "No 74, Anna Salai, Guindy, Chennai - 600032, Opposite Guindy Police Station, Guindy Industrial Estate",
                    Status = RequestStatus.Reject
                },
                new ATMRequestModel
                {
                    RequestTime = "24 Auguest 2021 at 12:35 PM",
                    Address = "No 74, Anna Salai, Guindy, Chennai - 600032, Opposite Guindy Police Station, Guindy Industrial Estate",
                    Status = RequestStatus.Completed
                },
                new ATMRequestModel
                {
                    RequestTime = "24 Auguest 2021 at 12:35 PM",
                    Address = "No 74, Anna Salai, Guindy, Chennai - 600032, Opposite Guindy Police Station, Guindy Industrial Estate",
                    Status = RequestStatus.Pending
                },
                new ATMRequestModel
                {
                    RequestTime = "24 Auguest 2021 at 12:35 PM",
                    Address = "No 74, Anna Salai, Guindy, Chennai - 600032, Opposite Guindy Police Station, Guindy Industrial Estate",
                    Status = RequestStatus.Pending
                },
                new ATMRequestModel
                {
                    RequestTime = "24 Auguest 2021 at 12:35 PM",
                    Address = "No 74, Anna Salai, Guindy, Chennai - 600032, Opposite Guindy Police Station, Guindy Industrial Estate",
                    Status = RequestStatus.Reject
                },
                new ATMRequestModel
                {
                    RequestTime = "24 Auguest 2021 at 12:35 PM",
                    Address = "No 74, Anna Salai, Guindy, Chennai - 600032, Opposite Guindy Police Station, Guindy Industrial Estate",
                    Status = RequestStatus.Completed
                },
                new ATMRequestModel
                {
                    RequestTime = "24 Auguest 2021 at 12:35 PM",
                    Address = "No 74, Anna Salai, Guindy, Chennai - 600032, Opposite Guindy Police Station, Guindy Industrial Estate",
                    Status = RequestStatus.Pending
                }
            };

            listview.ItemsSource = myRequestList;

        }
    }
}