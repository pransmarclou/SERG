using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using MaterialDesignColors;
using MaterialDesignThemes;
using System.Windows.Media;
using MaterialDesignThemes.Wpf;
using MahApps.Metro.Controls;

namespace SERG
{
    /// <summary>
    /// Interaction logic for Invetorys.xaml
    /// </summary>
    public partial class Form2
    {
       

     

        public Form2()
        {
            InitializeComponent();

            try
            {
               
                InitializeMaterialDesign();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
       

    }
}