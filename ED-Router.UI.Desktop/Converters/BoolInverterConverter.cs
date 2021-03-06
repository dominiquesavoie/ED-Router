﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace ED_Router.UI.Desktop.Converters
{
    public class BoolInverterConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolValue = (value as bool?)??false;

            return !boolValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolValue = (value as bool?) ?? false;

            return !boolValue;
        }
    }
}
