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
using System.Windows.Forms;
using System.Windows.Documents;
using System.Media;


namespace SERG
{
    /// <summary>
    /// Interaction logic for Invetorys.xaml
    /// </summary>
    public partial class Form
    {
       
        private int functionType { get; set; }
        private short fEval { get; set; }
        private short sEval { get; set; }
        private short btEval { get; set; }
        private short eEval { get; set; }
        private short pEval { get; set; }
        private short tsuEval { get; set; }
        private short tyEval { get; set; }
        private string actVal { get; set; }
        private string detVal { get; set; }

        private void RiskEvalCheck(int type, bool high, bool med, bool low, bool none)
        {
            if (high == true) //0-high, 1-med, 2-low, 3-none
            {
                if (type == 0)
                    fEval = 0;
                else if (type == 1)
                    sEval = 0;
                else if (type == 2)
                    btEval = 0;
                else if (type == 3)
                    eEval = 0;
                else if (type == 4)
                    pEval = 0;
                else if (type == 5)
                    tsuEval = 0;
                else if (type == 6)
                    tyEval = 0;
            }
            else if (med == true)
            {
                if (type == 0)
                    fEval = 1;
                else if (type == 1)
                    sEval = 1;
                else if (type == 2)
                    btEval = 1;
                else if (type == 3)
                    eEval = 1;
                else if (type == 4)
                    pEval = 1;
                else if (type == 5)
                    tsuEval = 1;
                else if (type == 6)
                    tyEval = 1;
            }
            else if (low == true)
            {
                if (type == 0)
                    fEval = 2;
                else if (type == 1)
                    sEval = 2;
                else if (type == 2)
                    btEval = 2;
                else if (type == 3)
                    eEval = 2;
                else if (type == 4)
                    pEval = 2;
                else if (type == 5)
                    tsuEval = 2;
                else if (type == 6)
                    tyEval = 2;
            }
            else if (none == true)
            {
                if (type == 0)
                    fEval = 3;
                else if (type == 1)
                    sEval = 3;
                else if (type == 2)
                    btEval = 0;
                else if (type == 3)
                    eEval = 3;
                else if (type == 4)
                    pEval = 3;
                else if (type == 5)
                    tsuEval = 3;
                else if (type == 6)
                    tyEval = 3;
            }
        }


        public Form()
        {
            InitializeComponent();
            try
            {
               
                InitializeMaterialDesign();
            }
            catch (System.Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
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

        private void CheckTextFields()
        {
            actVal = new TextRange(rtxtAction.Document.ContentStart, rtxtAction.Document.ContentEnd).Text;
            detVal = new TextRange(rtxtDetails.Document.ContentStart, rtxtDetails.Document.ContentEnd).Text;
            try
            {
                if (string.IsNullOrWhiteSpace(txtDesignation.Text) && 
                    string.IsNullOrWhiteSpace(txtEndorsement.Text) &&
                    string.IsNullOrWhiteSpace(txtHazard.Text) &&
                    string.IsNullOrWhiteSpace(txtNotedName.Text) &&
                    string.IsNullOrWhiteSpace(txtNotedTitle.Text) &&
                    string.IsNullOrWhiteSpace(txtPreparedName.Text) &&
                    string.IsNullOrWhiteSpace(txtPreparedTitle.Text) &&
                    string.IsNullOrWhiteSpace(txtRe.Text) && 
                    string.IsNullOrWhiteSpace(txtRemarks.Text) &&
                    string.IsNullOrWhiteSpace(txtRoom.Text) &&
                    string.IsNullOrWhiteSpace(txtSerialNumber.Text) &&
                    string.IsNullOrWhiteSpace(txtSeverity.Text) &&
                    string.IsNullOrWhiteSpace(actVal) &&
                    string.IsNullOrWhiteSpace(detVal) )
                {
                   throw new Exception("Please Complete The Required Details!");
                }
            }
            catch (Exception ex)
            {

                SystemSounds.Beep.Play();
                System.Windows.MessageBox.Show("Error: " + ex.Message, "Empty TextFields", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (txtSerialNumber.IsEnabled == true)
                functionType = 0;
            else
                functionType = 1;

                RiskEvalCheck(0,
                    rdbRiskEval_Fire_High.IsChecked.Value,
                    rdbRiskEval_Fire_Med.IsChecked.Value,
                    rdbRiskEval_Fire_Low.IsChecked.Value,
                    rdbRiskEval_Fire_NA.IsChecked.Value);

                RiskEvalCheck(1,
                    rdbRiskEval_Smoke_High.IsChecked.Value,
                    rdbRiskEval_Smoke_Med.IsChecked.Value,
                    rdbRiskEval_Smoke_Low.IsChecked.Value,
                    rdbRiskEval_Smoke_NA.IsChecked.Value);

                RiskEvalCheck(2,
                    rdbRiskEval_Bomb_High.IsChecked.Value,
                    rdbRiskEval_Bomb_Med.IsChecked.Value,
                    rdbRiskEval_Bomb_Low.IsChecked.Value,
                    rdbRiskEval_Bomb_NA.IsChecked.Value);

                RiskEvalCheck(3,
                    rdbRiskEval_Earthquake_High.IsChecked.Value,
                    rdbRiskEval_Earthquake_Med.IsChecked.Value,
                    rdbRiskEval_Earthquake_Low.IsChecked.Value,
                    rdbRiskEval_Earthquake_NA.IsChecked.Value);

                RiskEvalCheck(4,
                    rdbRiskEval_Protest_High.IsChecked.Value,
                    rdbRiskEval_Protest_Med.IsChecked.Value,
                    rdbRiskEval_Protest_Low.IsChecked.Value,
                    rdbRiskEval_Protest_NA.IsChecked.Value);

                RiskEvalCheck(5,
                    rdbRiskEval_Tsunami_High.IsChecked.Value,
                    rdbRiskEval_Tsunami_Med.IsChecked.Value,
                    rdbRiskEval_Tsunami_Low.IsChecked.Value,
                    rdbRiskEval_Tsunami_NA.IsChecked.Value);

                RiskEvalCheck(6,
                    rdbRiskEval_Typhoon_High.IsChecked.Value,
                    rdbRiskEval_Typhoon_Med.IsChecked.Value,
                    rdbRiskEval_Typhoon_Low.IsChecked.Value,
                    rdbRiskEval_Typhoon_NA.IsChecked.Value);

                actVal = new TextRange(rtxtAction.Document.ContentStart, rtxtAction.Document.ContentEnd).Text;
                detVal = new TextRange(rtxtDetails.Document.ContentStart, rtxtDetails.Document.ContentEnd).Text;

                Model.SERGForms objSModel = new SERG.Model.SERGForms(
                    functionType,
                    txtSerialNumber.Text,

                    fEval,
                    sEval,
                    btEval,
                    eEval,
                    pEval,
                    tsuEval,
                    tyEval,

                    txtRe.Text,
                    txtRoom.Text,
                    txtDesignation.Text,
                    txtHazard.Text,
                    txtSeverity.Text,
                    txtEndorsement.Text,
                    cmbClass.IsSelected, 
                    dpDatePrepared.SelectedDate.Value,
                    txtPreparedTitle.Text,
                    txtPreparedName.Text,
                    txtNotedTitle.Text,
                    txtNotedName.Text,
                    txtRemarks.Text,

                    chkFaculty.IsChecked.Value,
                    chkStudents.IsChecked.Value,
                    chkLabPersonel.IsChecked.Value,
                    chkEquipment.IsChecked.Value,

                    chkImmRec.IsChecked.Value,
                    chkIncluSafety.IsChecked.Value,
                    actVal,
                    detVal                 
                    

               );

            MessageBoxResult question = System.Windows.MessageBox.Show("Do you want to create a word document file?", "Printable Copy", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(question == MessageBoxResult.Yes)
            {
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                string filepath = Environment.CurrentDirectory + @"\template.docx";
                Document wordDoc = wordApp.Documents.Open(filepath);
                wordDoc.Activate();

                var dialog = new System.Windows.Forms.FolderBrowserDialog();
                //Set default directory to the desktop.
                dialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                dialog.Description = "Please choose the folder where the file will be saved (default location is the desktop)";
                dialog.RootFolder = Environment.SpecialFolder.Personal;
                System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                
                

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

                // Assign the values according to user input
                Date.Text = dpDatePrepared.Text;
                SerialNumber.Text = txtSerialNumber.Text;
                RE.Text = txtRe.Text;

                if ((bool)chkImmRec.IsChecked)
                    Action_Immediate.Text = "☒";
                else
                    Action_Immediate.Text = "☐";

                if ((bool)chkIncluSafety.IsChecked)
                    Action_Inclusion.Text = "☒";
                else
                    Action_Inclusion.Text = "☐";

                Room.Text = txtRoom.Text;
                Hazard.Text = txtHazard.Text;
                Designation.Text = txtDesignation.Text;

                if ((bool)chkFaculty.IsChecked)
                    AtRisk_Faculty.Text = "☒";
                else
                    AtRisk_Faculty.Text = "☐";

                if ((bool)chkStudents.IsChecked)
                    AtRisk_Students.Text = "☒";
                else
                    AtRisk_Students.Text = "☐";

                if ((bool)chkLabPersonel.IsChecked)
                    AtRisk_Lab.Text = "☒";
                else
                    AtRisk_Lab.Text = "☐";

                if ((bool)chkEquipment.IsChecked)
                    AtRisk_Equipment.Text = "☒";
                else
                    AtRisk_Equipment.Text = "☐";

                Severity.Text = txtSeverity.Text;
                EndorsementNumber.Text = txtEndorsement.Text;

                //ADD THE RISK EVAL RESULTS LATER

                Details.Text = new TextRange(rtxtDetails.Document.ContentStart, rtxtDetails.Document.ContentEnd).Text;
                Action.Text = new TextRange(rtxtAction.Document.ContentStart, rtxtAction.Document.ContentEnd).Text;
                Prep_Name.Text = txtPreparedName.Text;
                Prep_Title.Text = txtPreparedTitle.Text;
                Noted_Name.Text = txtNotedName.Text;
                Noted_Title.Text = txtNotedTitle.Text;
                
                //ADD THE LAB OR ROOM TEXT;

                //RiskEval_Bomb_High.Text = "☐";  // USE FOR UNCHECKED TEXTBOX
                //RiskEval_Earthquake_High.Text = "☒"; // USE FOR CHECKED TEXTBOX



                wordDoc.SaveAs2(dialog.SelectedPath + "//" + SerialNumber.Text + ".docx"); 
                wordDoc.Close();
                wordApp.Quit();
                
                // rng.Text = "Adams Laura"; //Get value from any where      
            }
            else
            {
                // code to save to database or some shit
            }


        }

        private void FormIsClosed(object sender, EventArgs e)
        {
            Update objUpdate = new Update();
            objUpdate.dgdData.ItemsSource = null;
            objUpdate.ShowingDataGrid();
        }
    }
}