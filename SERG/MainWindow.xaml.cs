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

namespace SERG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeAllUserControl();
        }

        public void InitializeAllUserControl()
        {
            this.lstDockLeft.SelectedIndex = 0;
            cntControl.Content = new Home();

            this.btnHome.IsEnabled = true;
            this.btnForm1.IsEnabled = true;
            this.btnForm2.IsEnabled = true;
          

            this.txbTitle.Text = "Home";

        }
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            InitializeAllUserControl();
            this.lstDockLeft.SelectedIndex = 0;
            cntControl.Content = new Home();
            this.btnHome.IsEnabled = false;
            this.txbTitle.Text = "Home";
        }
        private void btnForm1_Click(object sender, RoutedEventArgs e)
        {
            InitializeAllUserControl();
            cntControl.Content = new Form1();
            this.lstDockLeft.SelectedIndex = 1;
            this.btnForm1.IsEnabled = false;
            this.txbTitle.Text = "Form1";
        }

        private void btnForm2_Click(object sender, RoutedEventArgs e)
        {
            InitializeAllUserControl();
            cntControl.Content = new Form2();
            this.lstDockLeft.SelectedIndex = 2;
            this.btnForm2.IsEnabled = false;
            this.txbTitle.Text = "Risk Evaluation";
        }
    }
}
