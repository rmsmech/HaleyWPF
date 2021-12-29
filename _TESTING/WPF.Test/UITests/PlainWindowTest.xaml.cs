﻿using Haley.Abstractions;
using Haley.Enums;
using Haley.Events;
using Haley.Models;
using Haley.MVVM;
using Haley.WPF.Controls;
using Haley.Utils;
using System;
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
using System.Windows.Shapes;



namespace WPF.Test.UITests
{
    /// <summary>
    /// Interaction logic for PlainWindowTest.xaml
    /// </summary>
    public partial class PlainWindowTest : PlainWindow
    {
        public PlainWindowTest()
        {

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var _ds = ContainerStore.Singleton.DI.Resolve<IDialogService>();
            _ds.Info("Working", "message raised");
        }
    }
}
