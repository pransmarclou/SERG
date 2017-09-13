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
            cntControl.Content = new Update();
        }

        public void InitializeAllUserControl()
        {
            this.lstDockLeft.SelectedIndex = 0;
            cntControl.Content = new Home();

            this.btnHome.IsEnabled = true;
         
           
          

            this.txbTitle.Text = "Home";

        }
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            InitializeAllUserControl();
            this.lstDockLeft.SelectedIndex = 0;
            cntControl.Content = new Update();
            this.btnHome.IsEnabled = false;
            this.txbTitle.Text = "Home";
        }
      

        public void Form1()
        {
            InitializeAllUserControl();
            cntControl.Content = new Form();            
            this.txbTitle.Text = "Add Form";
        }

        private void WindowClosed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
