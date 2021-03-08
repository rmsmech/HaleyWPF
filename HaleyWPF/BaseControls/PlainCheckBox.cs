﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Haley.Abstractions;
using Haley.Utils;
using Haley.Enums;

namespace Haley.WPF.BaseControls
{
    public class PlainCheckBox : CheckBox, IHoverBorder
    {
        private const double min_TickBoxSize = 15.0;
        private const double max_TickBoxSize = 25.0;
        static PlainCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PlainCheckBox), new FrameworkPropertyMetadata(typeof(PlainCheckBox)));
        }

        public PlainCheckBox() { }

        public Thickness HoverBorderThickness
        {
            get { return (Thickness)GetValue(HoverBorderThicknessProperty); }
            set { SetValue(HoverBorderThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HoverBorderThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HoverBorderThicknessProperty =
            DependencyProperty.Register(nameof(HoverBorderThickness), typeof(Thickness), typeof(PlainCheckBox), new PropertyMetadata(null));

        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HoverBorderBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HoverBorderBrushProperty =
            DependencyProperty.Register(nameof(HoverBorderBrush), typeof(Brush), typeof(PlainCheckBox), new PropertyMetadata(null));

        public SolidColorBrush TickColor
        {
            get { return (SolidColorBrush)GetValue(TickColorProperty); }
            set { SetValue(TickColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TickColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TickColorProperty =
            DependencyProperty.Register(nameof(TickColor), typeof(SolidColorBrush), typeof(PlainCheckBox), new PropertyMetadata(null));

        public double TickBoxSize
        {
            get { return (double)GetValue(TickBoxSizeProperty); }
            set { SetValue(TickBoxSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TickBoxSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TickBoxSizeProperty =
            DependencyProperty.Register(nameof(TickBoxSize), typeof(double), typeof(PlainCheckBox), new FrameworkPropertyMetadata(16.0, new PropertyChangedCallback(TickBoxSizePropertyChanged), ValidatTickBoxSize));
        static void TickBoxSizePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //
        }
        static object ValidatTickBoxSize(DependencyObject d, object baseValue)
        {
            var current_value = (double)baseValue;
            if (current_value < min_TickBoxSize) return min_TickBoxSize;
            if (current_value > max_TickBoxSize) return max_TickBoxSize;
            return baseValue;
        }
    }
}
