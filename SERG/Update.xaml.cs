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
        private string serialNumber;


        public Update()
        {
            InitializeComponent();

            try
            {
               
                InitializeMaterialDesign();
                btnEdit.IsEnabled = false;
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

            dgdData.ItemsSource = null;
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
                Controller.SERGForms objController = new Controller.SERGForms(serialNumber);
                DataTable data = new DataTable("SelectedData");
                data = objController.SelectedData();
                Form = new Form();

                Form.txtSerialNumber.Text = data.Rows[0]["SerialNum"].ToString();
                Form.txtRe.Text = data.Rows[0]["RE"].ToString();
                Form.txtRoom.Text = data.Rows[0]["Room"].ToString();
                Form.txtDesignation.Text = data.Rows[0]["Designation"].ToString();
                Form.txtHazard.Text = data.Rows[0]["Hazard"].ToString();
                Form.txtSeverity.Text = data.Rows[0]["Severity"].ToString();
                Form.txtEndorsement.Text = data.Rows[0]["EndorsementNum"].ToString();
                if (Convert.ToBoolean(data.Rows[0]["LabOrRoom"]) == true)
                    Form.cmbLabOrRoom.SelectedItem = Form.cmbClass;
                else
                    Form.cmbLabOrRoom.SelectedItem = Form.cmbLab;
                Form.dpDatePrepared.Text = data.Rows[0]["PrepDate"].ToString();
                Form.txtPreparedTitle.Text = data.Rows[0]["titlePreparedBy"].ToString();
                Form.txtNotedTitle.Text = data.Rows[0]["titleNotedBy"].ToString();
                Form.txtPreparedName.Text = data.Rows[0]["namePreparedBy"].ToString();
                Form.txtNotedName.Text = data.Rows[0]["nameNotedBy"].ToString();
                Form.txtRemarks.Text = data.Rows[0]["remarks"].ToString();

                if(Convert.ToInt16(data.Rows[0]["FireEval"]) == 0)
                {
                    Form.rdbRiskEval_Fire_High.IsChecked = true;
                }
                else if(Convert.ToInt16(data.Rows[0]["FireEval"]) == 1)
                {
                    Form.rdbRiskEval_Fire_Med.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["FireEval"]) == 2)
                {
                    Form.rdbRiskEval_Fire_Low.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["FireEval"]) == 3)
                {
                    Form.rdbRiskEval_Fire_NA.IsChecked = true;
                }

                if (Convert.ToInt16(data.Rows[0]["SmokeEval"]) == 0)
                {
                    Form.rdbRiskEval_Smoke_High.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["SmokeEval"]) == 1)
                {
                    Form.rdbRiskEval_Smoke_Med.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["SmokeEval"]) == 2)
                {
                    Form.rdbRiskEval_Smoke_Low.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["SmokeEval"]) == 3)
                {
                    Form.rdbRiskEval_Smoke_NA.IsChecked = true;
                }

                if (Convert.ToInt16(data.Rows[0]["BombThreatEval"]) == 0)
                {
                    Form.rdbRiskEval_Bomb_High.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["BombThreatEval"]) == 1)
                {
                    Form.rdbRiskEval_Bomb_Med.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["BombThreatEval"]) == 2)
                {
                    Form.rdbRiskEval_Bomb_Low.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["BombThreatEval"]) == 3)
                {
                    Form.rdbRiskEval_Bomb_NA.IsChecked = true;
                }

                if (Convert.ToInt16(data.Rows[0]["EarthquakeEval"]) == 0)
                {
                    Form.rdbRiskEval_Earthquake_High.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["EarthquakeEval"]) == 1)
                {
                    Form.rdbRiskEval_Earthquake_Med.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["EarthquakeEval"]) == 2)
                {
                    Form.rdbRiskEval_Earthquake_Low.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["EarthquakeEval"]) == 3)
                {
                    Form.rdbRiskEval_Earthquake_NA.IsChecked = true;
                }

                if (Convert.ToInt16(data.Rows[0]["ProtestEval"]) == 0)
                {
                    Form.rdbRiskEval_Protest_High.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["ProtestEval"]) == 1)
                {
                    Form.rdbRiskEval_Protest_Med.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["ProtestEval"]) == 2)
                {
                    Form.rdbRiskEval_Protest_Low.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["ProtestEval"]) == 3)
                {
                    Form.rdbRiskEval_Protest_NA.IsChecked = true;
                }

                if (Convert.ToInt16(data.Rows[0]["TsunamiEval"]) == 0)
                {
                    Form.rdbRiskEval_Tsunami_High.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["TsunamiEval"]) == 1)
                {
                    Form.rdbRiskEval_Tsunami_Med.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["TsunamiEval"]) == 2)
                {
                    Form.rdbRiskEval_Tsunami_Low.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["TsunamiEval"]) == 3)
                {
                    Form.rdbRiskEval_Tsunami_NA.IsChecked = true;
                }

                if (Convert.ToInt16(data.Rows[0]["TyphoonEval"]) == 0)
                {
                    Form.rdbRiskEval_Typhoon_High.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["TyphoonEval"]) == 1)
                {
                    Form.rdbRiskEval_Typhoon_Med.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["TyphoonEval"]) == 2)
                {
                    Form.rdbRiskEval_Typhoon_Low.IsChecked = true;
                }
                else if (Convert.ToInt16(data.Rows[0]["TyphoonEval"]) == 3)
                {
                    Form.rdbRiskEval_Typhoon_NA.IsChecked = true;
                }


                if (Convert.ToBoolean(data.Rows[0]["Faculty"]) == true)
                    Form.chkFaculty.IsChecked = true;
                else
                    Form.chkFaculty.IsChecked = false;

                if (Convert.ToBoolean(data.Rows[0]["Students"]) == true)
                    Form.chkStudents.IsChecked = true;
                else
                    Form.chkStudents.IsChecked = false;

                if (Convert.ToBoolean(data.Rows[0]["PersonnelAndCohorts"]) == true)
                    Form.chkLabPersonel.IsChecked = true;
                else
                    Form.chkLabPersonel.IsChecked = false;

                if (Convert.ToBoolean(data.Rows[0]["Equipment"]) == true)
                    Form.chkEquipment.IsChecked = true;
                else
                    Form.chkEquipment.IsChecked = false;


                Form.rtxtDetails.AppendText(data.Rows[0]["DetailVal"].ToString());
                Form.rtxtAction.AppendText(data.Rows[0]["ActionVal"].ToString());

                if (Convert.ToBoolean(data.Rows[0]["ABRectification"]) == true)
                    Form.chkImmRec.IsChecked = true;
                else
                    Form.chkImmRec.IsChecked = false;

                if (Convert.ToBoolean(data.Rows[0]["ABSafetyPlan"]) == true)
                    Form.chkIncluSafety.IsChecked = true;
                else
                    Form.chkIncluSafety.IsChecked = false;

                Form.Show();
                Form.txtSerialNumber.IsEnabled = false;

               // objController.ShowToDataGrid();

                ShowingDataGrid();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"Form Error",MessageBoxButton.OK,MessageBoxImage.Error);

            }
      
           
        }

        private void DataGridSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                System.Data.DataRowView select = (System.Data.DataRowView)dgdData.SelectedItem;
                serialNumber = select.Row.ItemArray[0].ToString();
                if (serialNumber != null)
                    btnEdit.IsEnabled = true;
                else
                    btnEdit.IsEnabled = false;
            }
            catch (Exception ex)
            {
                btnEdit.IsEnabled = false;
                ShowingDataGrid();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult msgResult = MessageBox.Show("Do You Really Want To Delete The Item?", "Confirm Deletion", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (msgResult == MessageBoxResult.Yes)
                {
                    System.Data.DataRowView select = (System.Data.DataRowView)dgdData.SelectedItem;
                    serialNumber = select.Row.ItemArray[0].ToString();


                    Controller.SERGForms objController = new Controller.SERGForms(serialNumber);
                    objController.DeleteForm();
                    MessageBox.Show("You've Successfully Deleted the Item!", "Inventory", MessageBoxButton.OK, MessageBoxImage.Information);

                    ShowingDataGrid();
                }
                else
                {
                    ShowingDataGrid();
                }
              

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Form Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}