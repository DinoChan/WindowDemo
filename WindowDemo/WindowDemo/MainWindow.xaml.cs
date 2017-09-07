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

namespace WindowDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResizeModeElement.Items.Add(ResizeMode.CanMinimize);
            ResizeModeElement.Items.Add(ResizeMode.CanResize);
            ResizeModeElement.Items.Add(ResizeMode.CanResizeWithGrip);
            ResizeModeElement.Items.Add(ResizeMode.NoResize);
            ResizeModeElement.SelectedIndex = 1;

        }

        private void OnShowTestWindow(object sender, RoutedEventArgs e)
        {
            var window = new TestWindow();
            window.ResizeMode = (ResizeMode) ResizeModeElement.SelectedItem;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.Owner = this;
            window.Show();
        }
    }
}
