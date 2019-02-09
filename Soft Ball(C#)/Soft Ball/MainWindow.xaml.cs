using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace Soft_Ball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           // radiusTextBox.Text = rSlider.Value + "";
        }

        private void pSlider_valueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
          //  final_p_textBox.Text = fpSlider.Value + "" ;
        }

        
        private void massSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //massTextBox.Text = massSlider.Value + "";
        }

        private void ksSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //ksTextBox.Text = ksSlider.Value + "";
        }

        private void kdSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //kdTextBox.Text = kdSlider.Value + "";
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process a = new Process();
            // getting the link for c++ exe..
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            projectDirectory = Directory.GetParent(projectDirectory).Parent.FullName + "\\The project(C++)\\Debug\\ConsoleApplication1.exe";
            a.StartInfo.FileName = "~\\The project(C++)\\Debug\\ConsoleApplication1.exe";
            a.StartInfo.Arguments = ksSlider.Value+" "+kdSlider.Value+" "+massSlider.Value+" "+rSlider.Value+" "+fpSlider.Value;
            a.Start();
            a.WaitForExit();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            rSlider.Value = 1.0;
            massSlider.Value = 1;
            ksSlider.Value = 1755;
            kdSlider.Value = 35;
            fpSlider.Value = 99;
          
        }

    }
}
