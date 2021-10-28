using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AtmRequest
{
    class StatusToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (RequestStatus)value;
            var imageName = "schedule_24px";
            switch (status)
            {
                case RequestStatus.Pending:
                    imageName = "schedule_24px";
                    break;
                case RequestStatus.Reject:
                    imageName = "do_disturb_alt_24px";
                    break;
                case RequestStatus.Completed:
                    imageName = "done_24px";
                    break;
            }
            return imageName;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
