using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.CodeDom.Compiler;
using System.Diagnostics;
using CheckUp2.Models;
using CheckUp2.ViewModels;

namespace CheckUp2 {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page {

        BackgroundDataViewModel BackgroundData;

        public MainPage() {
            this.InitializeComponent();
            InitializeViewModels();
            DataListView.DataContext = BackgroundData.BackgroundData;
        }

        private void InitializeViewModels() {
            BackgroundData = new BackgroundDataViewModel();
        }

        private void DataGatherButton_Click(object sender, RoutedEventArgs e) {
            // test adding data to viewmodel
            BackgroundDataModel data = new BackgroundDataModel("Process", 10, 1024, 1, 10);
            BackgroundData.AddData(data);
        }
    }
}
