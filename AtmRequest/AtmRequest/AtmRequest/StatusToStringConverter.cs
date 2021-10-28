using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AtmRequest
{
    class StatusToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (RequestStatus) value;
            var statusString = "Pending";
            switch (status)
            {
                case RequestStatus.Pending:
                    statusString = "Pending";
                    break;
                case RequestStatus.Reject:
                    statusString = "Reject";
                    break;
                case RequestStatus.Completed:
                    statusString = "Completed";
                    break;
            }
            return statusString;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
