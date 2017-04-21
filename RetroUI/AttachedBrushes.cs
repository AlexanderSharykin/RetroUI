using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace RetroUI
{
    public static class Alt
    {
        #region Background
        public static readonly DependencyProperty BackgroundProperty = DependencyProperty.RegisterAttached("Background", typeof(Brush), typeof(Alt));

        public static Brush GetBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(Alt.BackgroundProperty);
        }

        public static void SetBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(Alt.BackgroundProperty, value);
        }
        #endregion

        #region Foreground
        public static readonly DependencyProperty ForegroundProperty = DependencyProperty.RegisterAttached("Foreground", typeof(Brush), typeof(Alt));

        public static Brush GetForeground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(Alt.ForegroundProperty);
        }

        public static void SetForeground(DependencyObject obj, Brush value)
        {
            obj.SetValue(Alt.ForegroundProperty, value);
        }
        #endregion
    }

    public static class Selected
    {
        #region Background
        public static readonly DependencyProperty BackgroundProperty = DependencyProperty.RegisterAttached("Background", typeof(Brush), typeof(Selected));

        public static Brush GetBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(Selected.BackgroundProperty);
        }

        public static void SetBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(Selected.BackgroundProperty, value);
        }
        #endregion

        #region Foreground
        public static readonly DependencyProperty ForegroundProperty = DependencyProperty.RegisterAttached("Foreground", typeof(Brush), typeof(Selected));

        public static Brush GetForeground(DependencyObject obj)
        {
            return (Brush) obj.GetValue(Selected.ForegroundProperty);
        }

        public static void SetForeground(DependencyObject obj, Brush value)
        {
            obj.SetValue(Selected.ForegroundProperty, value);
        }
        #endregion
    }

    public static class Disabled
    {
        #region Background
        public static readonly DependencyProperty BackgroundProperty = DependencyProperty.RegisterAttached("Background", typeof(Brush), typeof(Disabled));

        public static Brush GetBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(Disabled.BackgroundProperty);
        }

        public static void SetBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(Disabled.BackgroundProperty, value);
        }
        #endregion

        #region Foreground
        public static readonly DependencyProperty ForegroundProperty = DependencyProperty.RegisterAttached("Foreground", typeof(Brush), typeof(Disabled));

        public static Brush GetForeground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(Disabled.ForegroundProperty);
        }

        public static void SetForeground(DependencyObject obj, Brush value)
        {
            obj.SetValue(Disabled.ForegroundProperty, value);
        }
        #endregion
    }
}
