using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AtmRequest
{
    class StatusToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (RequestStatus)value;
            var statusColor = Color.FromHex("#FFA700");
            switch (status)
            {
                case RequestStatus.Pending:
                    statusColor = Color.FromHex("#FFA700");
                    break;
                case RequestStatus.Reject:
                    statusColor = Color.FromHex("#B72424");
                    break;
                case RequestStatus.Completed:
                    statusColor = Color.FromHex("#448D4C");
                    break;
            }
            return statusColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
