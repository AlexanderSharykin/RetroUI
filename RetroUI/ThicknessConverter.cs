using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace RetroUI
{
    // http://stackoverflow.com/questions/6249518/binding-only-part-of-the-margin-property-of-wpf-control
    public class MyThicknessConverter: IValueConverter
    {        
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (false == (value is Thickness))
                return value;

            Thickness result = new Thickness();

            if (parameter != null)
            {
                Thickness thick = (Thickness) value;
                string p = parameter.ToString().ToLower();
                var parts = p.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 4)
                {
                    double[] values = parts
                        .Select(x => Parse(x) ?? GetThicknessPart(thick, x) ?? 0)
                        .ToArray();

                    result.Left = values[0];
                    result.Top = values[1];
                    result.Right = values[2];
                    result.Bottom = values[3];
                }
            }
            return result;
        }

        private double? Parse(string s)
        {
            double i = 0;
            if (double.TryParse(s, out i))
                return i;
            return null;
        }

        private double? GetThicknessPart(Thickness thick, string name)
        {
            int sign = name[0] == '-' ? -1 : 1;
            name = name.Trim('-');
            double? result = null;
            switch (name)
            {
                case "top":    result = thick.Top;    break;
                case "bottom": result = thick.Bottom; break;
                case "left":   result = thick.Left;   break;
                case "right":  result = thick.Right;  break;
            }
            if (result != null)
                result *= sign;
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;            
        }
    }
}
