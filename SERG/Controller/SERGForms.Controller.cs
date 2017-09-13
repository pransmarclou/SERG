using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using SERG.Model;
using System.Windows.Documents;
using System.Windows;

namespace SERG.Controller
{
    class SERGForms
    {
        //connection string
        private string cnString = ConfigurationManager.ConnectionStrings["cn_SERG"]?.ConnectionString;
        private int funcType { get; set; }

        private string serialNum;

        //Data RiskEval
        #region RiskEval
        //@fireEval smallint,
        //@smokeEval smallint, 
        //@bthreatEval smallint,
        //@earthquakeEval smallint,
        //@protestEval smallint,
        //@tsunamiEval smallint,
        //@typhoonEval smallint,

        private short fireEval;

        private short smokeEval;

        private short bombThreatEval;

        private short earthquakeEval;

        private short protestEval;

        private short tsunamiEval;

        private short typhoonEval;
        #endregion

        //data for SEReport
        #region SEReport
        //@rE varchar(50),
        //@room varchar(20),
        //@designation varchar(20),
        //@serialNumber varchar(20),
        //@hazard varchar(50),
        //@severity varchar(20),
        //@endorsementNum varchar(70),
        //@labOrRoom bit,
        //@prepDate date,
        //@tPrep varchar(10),
        //@tNoted varchar(10),
        //@namePrep varchar(50),
        //@nameNoted varchar(50),
        //@remarks varchar(70),

        private string riskEvaluation;

        private string room;

        private string designation;

        private string hazard;

        private string severity;

        private string endorsementNum;

        private bool labOrRoom;

        private DateTime prepDate;

        private string titlePreparedBy;

        private string namePreparedBy;

        private string titleNotedBy;

        private string nameNotedBy;

        private string remarks;
        #endregion



        #region WhoIsAtRisk
        //@isFaculty bit,
        //@isStudents bit,
        //@isPersonnel bit,
        //@isEquipment bit,
        private bool isFaculty;

        private bool isStudents;

        private bool isPersonnel;

        private bool isEquipment;
        #endregion

        #region ActionBoxAndOthers
        //@abRectification bit,
        //@abSafetyPlan bit,
        //@actionVal varchar(2000),
        //@detailVal varchar(2000)

        private bool abRectification;

        private bool abSafetyPlan;

        private string actionVal;

        private string detailVal;

        #endregion


        //Constructors

        public SERGForms()
        {

        }

        public SERGForms(string sNumb)
        {
            serialNum = sNumb;
        }

        public SERGForms(
            int functionType,
            string sNumber,

            //riskeval
            short fEval,
            short sEval,
            short btEval,
            short eEval,
            short pEval,
            short tsuEval,
            short tyEval,

            //sereport
            string rEval,
            string rm,
            string desig,
            string haz,
            string sev,
            string endNum,
            bool lOrR,
            DateTime prepD,
            string titlePB,
            string namePB,
            string titleNB,
            string nameNB,
            string rem,

            //whoisatrisk
            bool isFac,
            bool isStud,
            bool isPer,
            bool isEquip,

            //actionbox and otehrs
            bool abRec,
            bool abSafety,
            string actVal,
            string detVal )
        {
            
            funcType = functionType;
            serialNum = sNumber;

            //risk eval
            fireEval = fEval;
            smokeEval = sEval;
            bombThreatEval = btEval;
            earthquakeEval = eEval;
            protestEval = pEval;
            tsunamiEval = tsuEval;
            typhoonEval = tyEval;

            //sereport
            riskEvaluation = rEval;
            room = rm;
            designation = desig;
            hazard = haz;
            severity = sev;
            endorsementNum = endNum;
            labOrRoom = lOrR;
            prepDate = prepD;
            titlePreparedBy = titlePB;
            namePreparedBy = namePB;
            titleNotedBy = titleNB;
            nameNotedBy = nameNB;
            remarks = rem;

            //whoisatrisk
            isFaculty = isFac;
            isStudents = isStud;
            isPersonnel = isPer;
            isEquipment = isEquip;

            //actionboxandothers
            abRectification = abRec;
            abSafetyPlan = abSafety;
            actionVal = actVal;
            detailVal = detVal;


        }


        //Functions 

        public void AddForm()
        {
            try
            {
                using (SqlConnection sq_connect = new SqlConnection(cnString))
                using (SqlCommand sq_command = new SqlCommand("AddForm", sq_connect))
                {
                    sq_command.CommandType = CommandType.StoredProcedure;
                    sq_command.Parameters.Add("rE", SqlDbType.VarChar).Value = riskEvaluation;
                    sq_command.Parameters.Add("room", SqlDbType.VarChar).Value = room;
                    sq_command.Parameters.Add("designation", SqlDbType.VarChar).Value = designation;
                    sq_command.Parameters.Add("serialNumber", SqlDbType.VarChar).Value = serialNum;
                    sq_command.Parameters.Add("hazard", SqlDbType.VarChar).Value = hazard;
                    sq_command.Parameters.Add("severity", SqlDbType.VarChar).Value = severity;
                    sq_command.Parameters.Add("endorsementNum", SqlDbType.VarChar).Value = endorsementNum;
                    sq_command.Parameters.Add("labOrRoom", SqlDbType.Bit).Value = labOrRoom;
                    sq_command.Parameters.Add("prepDate", SqlDbType.Date).Value = prepDate;
                    sq_command.Parameters.Add("tPrep", SqlDbType.VarChar).Value = titlePreparedBy;
                    sq_command.Parameters.Add("tNoted", SqlDbType.VarChar).Value = titleNotedBy;
                    sq_command.Parameters.Add("namePrep", SqlDbType.VarChar).Value = namePreparedBy;
                    sq_command.Parameters.Add("nameNoted", SqlDbType.VarChar).Value = nameNotedBy;
                    sq_command.Parameters.Add("remarks", SqlDbType.VarChar).Value = remarks;

                    sq_command.Parameters.Add("fireEval", SqlDbType.SmallInt).Value = fireEval;
                    sq_command.Parameters.Add("smokeEval", SqlDbType.SmallInt).Value = smokeEval;
                    sq_command.Parameters.Add("bthreatEval", SqlDbType.SmallInt).Value = bombThreatEval;
                    sq_command.Parameters.Add("earthquakeEval", SqlDbType.SmallInt).Value = earthquakeEval;
                    sq_command.Parameters.Add("protestEval", SqlDbType.SmallInt).Value = protestEval;
                    sq_command.Parameters.Add("tsunamiEval", SqlDbType.SmallInt).Value = tsunamiEval;
                    sq_command.Parameters.Add("typhoonEval", SqlDbType.SmallInt).Value = typhoonEval;

                    sq_command.Parameters.Add("isFaculty", SqlDbType.Bit).Value = isFaculty;
                    sq_command.Parameters.Add("isStudents", SqlDbType.Bit).Value = isStudents;
                    sq_command.Parameters.Add("isPersonnel", SqlDbType.Bit).Value = isPersonnel;
                    sq_command.Parameters.Add("isEquipment", SqlDbType.Bit).Value = isEquipment;

                    sq_command.Parameters.Add("abRectification", SqlDbType.Bit).Value = abRectification;
                    sq_command.Parameters.Add("abSafetyPlan", SqlDbType.Bit).Value = abSafetyPlan;

                    sq_command.Parameters.Add("actionVal", SqlDbType.VarChar).Value = actionVal;
                    sq_command.Parameters.Add("detailVal", SqlDbType.VarChar).Value = detailVal;

                    sq_connect.Open();
                    sq_command.ExecuteScalar();

                }

                MessageBox.Show("Created");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"The error is {ex}");
            }
        }


        public DataTable ShowToDataGrid()
        {

            DataTable existingData = new DataTable("SEReport");
            try
            {
                SqlDataAdapter results = null;
                using (SqlConnection sq_connect = new SqlConnection(cnString))
                using (SqlCommand sq_command = new SqlCommand("ShowToDataGrid", sq_connect))
                {
                    sq_command.CommandType = CommandType.StoredProcedure;
                    sq_connect.Open();

                    results = new SqlDataAdapter(sq_command);
                    results.Fill(existingData);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The error is {ex}");
            }

            return existingData;
        }


        public DataTable SelectedData()
        {

            DataTable dt = new DataTable("SelectedData");
            try
            {
                SqlDataAdapter res = null;
                using (SqlConnection sq_connect = new SqlConnection(cnString))
                using (SqlCommand sq_command = new SqlCommand("SelectData", sq_connect))
                {
                    sq_command.CommandType = CommandType.StoredProcedure;
                    sq_command.Parameters.Add("serialNumber", SqlDbType.VarChar).Value = serialNum;
                    sq_connect.Open();

                    res = new SqlDataAdapter(sq_command);
                    res.Fill(dt);

                    
                    

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show($"The error is {ex}");
            }

            return dt;
        }
        

        
        

        ////riskeval
        //string sNumber,
        //    short fEval,
        //    short sEval,
        //    short btEval,
        //    short eEval,
        //    short pEval,
        //    short tsuEval,
        //    short tyEval,

        //    //sereport
        //string rEval,
        //    string rm,
        //    string desig,
        //    string haz,
        //    string sev,
        //    string endNum,
        //    bool lOrR,
        //    DateTime prepD,
        //    string titlePB,
        //    string namePB,
        //    string titleNB,
        //    string nameNB,

        //    //whoisatrisk
        //bool isFac,
        //    bool isStud,
        //    bool isPer,
        //    bool isEquip,

        //    //actionbox and otehrs
        //bool abRec,
        //    bool abSafety,
        //    string actVal,
        //    string detVal
    }
}
