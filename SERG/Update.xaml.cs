using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using MaterialDesignColors;
using MaterialDesignThemes;
using System.Windows.Media;
using MaterialDesignThemes.Wpf;
using MahApps.Metro.Controls;
using System.Data;

namespace SERG
{
    /// <summary>
    /// Interaction logic for Invetorys.xaml
    /// </summary>
    public partial class Update
    {

        private Form Form = new Form();



        public Update()
        {
            InitializeComponent();

            try
            {
               
                InitializeMaterialDesign();
                ShowingDataGrid();
               
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ShowingDataGrid()
        {
            Controller.SERGForms objSERGForms = new Controller.SERGForms();
            DataTable existingData = new DataTable("data");
            existingData = objSERGForms.ShowToDataGrid();
            dgdData.ItemsSource = existingData.DefaultView;
        }

        private void InitializeMaterialDesign()
        {
            // Create dummy objects to force the MaterialDesign assemblies to be loaded
            // from this assembly, which causes the MaterialDesign assemblies to be searched
            // relative to this assembly's path. Otherwise, the MaterialDesign assemblies
            // are searched relative to Eclipse's path, so they're not found.
            var card = new Card();
            var hue = new Hue("Dummy", Colors.Black, Colors.White);
        }

       

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Form = new Form();
                Form.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }
            
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Form = new Form();
                Form.Show();
                Form.txtSerialNumber.IsEnabled = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
      
           
        }
    }
}