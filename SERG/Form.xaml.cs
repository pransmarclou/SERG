using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using MaterialDesignColors;
using MaterialDesignThemes;
using System.Windows.Media;
using MaterialDesignThemes.Wpf;
using MahApps.Metro.Controls;
using Microsoft.Office.Interop.Word;

namespace SERG
{
    /// <summary>
    /// Interaction logic for Invetorys.xaml
    /// </summary>
    public partial class Form
    {
       

     

        public Form()
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

        private void txtSeverity_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnCloseWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult question = MessageBox.Show("Do you want to create a word document file?", "Printable Copy", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(question == MessageBoxResult.Yes)
            {
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Document wordDoc = wordApp.Documents.Add(@"C:\Users\fhranz\documents\visual studio 2015\Projects\SERG\SERG\Word\template.docx");
                wordDoc.Activate();

                //Create ranges for the bookmarks.
                Range Date = wordDoc.Bookmarks["Date"].Range;
                Range SerialNumber = wordDoc.Bookmarks["SerialNumber"].Range;
                Range RE = wordDoc.Bookmarks["RE"].Range;
                Range Action_Immediate = wordDoc.Bookmarks["Action_Immediate"].Range;
                Range Action_Inclusion = wordDoc.Bookmarks["Action_Inclusion"].Range;
                Range Room = wordDoc.Bookmarks["Room"].Range;
                Range Hazard = wordDoc.Bookmarks["Hazard"].Range;
                Range Designation = wordDoc.Bookmarks["Designation"].Range;
                Range AtRisk_Faculty = wordDoc.Bookmarks["AtRisk_Faculty"].Range;
                Range AtRisk_Students = wordDoc.Bookmarks["AtRisk_Students"].Range;
                Range AtRisk_Lab = wordDoc.Bookmarks["AtRisk_Lab"].Range;
                Range AtRisk_Equipment = wordDoc.Bookmarks["AtRisk_Equipment"].Range;
                Range Severity = wordDoc.Bookmarks["Severity"].Range;
                Range EndorsementNumber = wordDoc.Bookmarks["EndorsementNumber"].Range;
                Range RiskEval_Fire_High = wordDoc.Bookmarks["RiskEval_Fire_High"].Range;
                Range RiskEval_Fire_Med = wordDoc.Bookmarks["RiskEval_Fire_Med"].Range;
                Range RiskEval_Fire_Low = wordDoc.Bookmarks["RiskEval_Fire_Low"].Range;
                Range RiskEval_Fire_NA = wordDoc.Bookmarks["RiskEval_Fire_NA"].Range;
                Range RiskEval_Smoke_High = wordDoc.Bookmarks["RiskEval_Smoke_High"].Range;
                Range RiskEval_Smoke_Med = wordDoc.Bookmarks["RiskEval_Smoke_Med"].Range;
                Range RiskEval_Smoke_Low = wordDoc.Bookmarks["RiskEval_Smoke_Low"].Range;
                Range RiskEval_Smoke_NA = wordDoc.Bookmarks["RiskEval_Smoke_NA"].Range;
                Range RiskEval_Bomb_High = wordDoc.Bookmarks["RiskEval_Bomb_High"].Range;
                Range RiskEval_Bomb_NA = wordDoc.Bookmarks["RiskEval_Bomb_NA"].Range;
                Range RiskEval_Earthquake_High = wordDoc.Bookmarks["RiskEval_Earthquake_High"].Range;
                Range RiskEval_Earthquake_Med = wordDoc.Bookmarks["RiskEval_Earthquake_Med"].Range;
                Range RiskEval_Earthquake_Low = wordDoc.Bookmarks["RiskEval_Earthquake_Low"].Range;
                Range RiskEval_Earthquake_NA = wordDoc.Bookmarks["RiskEval_Earthquake_NA"].Range;
                Range RiskEval_Protest_High = wordDoc.Bookmarks["RiskEval_Protest_High"].Range;
                Range RiskEval_Protest_Med = wordDoc.Bookmarks["RiskEval_Protest_Med"].Range;
                Range RiskEval_Protest_Low = wordDoc.Bookmarks["RiskEval_Protest_Low"].Range;
                Range RiskEval_Protest_NA = wordDoc.Bookmarks["RiskEval_Protest_NA"].Range;
                Range RiskEval_Tsunami_High = wordDoc.Bookmarks["RiskEval_Tsunami_High"].Range;
                Range RiskEval_Tsunami_Med = wordDoc.Bookmarks["RiskEval_Tsunami_Med"].Range;
                Range RiskEval_Tsunami_Low = wordDoc.Bookmarks["RiskEval_Tsunami_Low"].Range;
                Range RiskEval_Tsunami_NA = wordDoc.Bookmarks["RiskEval_Tsunami_NA"].Range;
                Range RiskEval_Typhoon_High = wordDoc.Bookmarks["RiskEval_Typhoon_High"].Range;
                Range RiskEval_Typhoon_Med = wordDoc.Bookmarks["RiskEval_Typhoon_Med"].Range;
                Range RiskEval_Typhoon_Low = wordDoc.Bookmarks["RiskEval_Typhoon_Low"].Range;
                Range RiskEval_Typhoon_NA = wordDoc.Bookmarks["RiskEval_Typhoon_NA"].Range;
                Range Details = wordDoc.Bookmarks["Details"].Range;
                Range Action = wordDoc.Bookmarks["Action"].Range;
                Range Prep_Name = wordDoc.Bookmarks["Prep_Name"].Range;
                Range Prep_Title = wordDoc.Bookmarks["Prep_Title"].Range;
                Range Remarks_Title = wordDoc.Bookmarks["Remarks_Title"].Range;
                Range Noted_Name = wordDoc.Bookmarks["Noted_Name"].Range;
                Range Noted_Title = wordDoc.Bookmarks["Noted_Title"].Range;
                Range LabOrRoom = wordDoc.Bookmarks["LabOrRoom"].Range;

                RiskEval_Bomb_High.Text = "☐";  // USE FOR UNCHECKED TEXTBOX
                RiskEval_Earthquake_High.Text = "☒"; // USE FOR CHECKED TEXTBOX



                wordDoc.SaveAs2(@"Word\new.docx");
                wordDoc.Close();
                wordApp.Quit();

                // rng.Text = "Adams Laura"; //Get value from any where      
            }
            else
            {
                // code to save to database or some shit
            }


        }
    }
}