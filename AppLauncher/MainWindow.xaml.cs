using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace AppLauncher
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void chrome_Click(object sender, RoutedEventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "Chrome.exe";
            p.Start();
        }

        private void word_Click(object sender, RoutedEventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "Word.exe";
            p.Start();
        }

        private void outlook_Click(object sender, RoutedEventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "Outlook.exe";
            p.Start();
        }

        private void youtube_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.youtube.com");
        }

        private void confluence_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://seu30.gdc-leinf01.t-systems.com/confluence/login.action?os_destination=%2Fpages%2Fviewpage.action%3FpageId%3D200152305&permissionViolation=true");
        }

        
    }
}
