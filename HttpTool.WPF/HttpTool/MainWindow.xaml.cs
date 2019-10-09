﻿using AduSkin.Controls.Metro;
using HttpTool.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HttpTool
{
   /// <summary>
   /// MainWindow.xaml 的交互逻辑
   /// </summary>
   public partial class MainWindow : AduWindow
   {
      public MainWindow()
      {
         InitializeComponent();
         this.DataContext = new MainWindowViewModel();
      }

      private void AduUpload_FileAduUpload(object sender, RoutedPropertyChangedEventArgs<object> e)
      {
         MainWindowViewModel vm = this.DataContext as MainWindowViewModel;
         vm.FileUploadCommand.Execute(e.NewValue);
      }
   }
}
