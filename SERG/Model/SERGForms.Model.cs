using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SERG.Model
{
    class SERGForms
    {


        private string serialNum { get; set; }
        private int funcType { get; set; }

        //Data RiskEval
        #region RiskEval
        //@fireEval smallint,
        //@smokeEval smallint, 
        //@bthreatEval smallint,
        //@earthquakeEval smallint,
        //@protestEval smallint,
        //@tsunamiEval smallint,
        //@typhoonEval smallint,

        private short fireEval { get; set; }

        private short smokeEval { get; set; }

        private short bombThreatEval { get; set; }

        private short earthquakeEval { get; set; }

        private short protestEval { get; set; }

        private short tsunamiEval { get; set; }

        private short typhoonEval { get; set; }
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

        private string riskEvaluation { get; set; }

        private string room { get; set; }

        private string designation { get; set; }

        private string hazard { get; set; }

        private string severity { get; set; }

        private string endorsementNum { get; set; }

        private bool labOrRoom { get; set; }

        private DateTime prepDate { get; set; }

        private string titlePreparedBy { get; set; }

        private string namePreparedBy { get; set; }

        private string titleNotedBy { get; set; }

        private string nameNotedBy { get; set; }

        private string remarks { get; set; }
        #endregion


        #region WhoIsAtRisk
        //@isFaculty bit,
        //@isStudents bit,
        //@isPersonnel bit,
        //@isEquipment bit,
        private bool isFaculty { get; set; }

        private bool isStudents { get; set; }

        private bool isPersonnel { get; set; }

        private bool isEquipment { get; set; }
        #endregion

        #region ActionBoxAndOthers
        //@abRectification bit,
        //@abSafetyPlan bit,
        //@actionVal varchar(2000),
        //@detailVal varchar(2000)

        private bool abRectification { get; set; }

        private bool abSafetyPlan { get; set; }

        private string actionVal { get; set; }

        private string detailVal { get; set; }

        #endregion

        //Constructors

        public SERGForms(string sNumber)
        {
            serialNum = sNumber;
        }

        
        //ADD and EDIT forms
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
            
            if(funcType == 0)
            {
                Controller.SERGForms objController = new Controller.SERGForms(funcType, serialNum, fireEval, smokeEval, bombThreatEval, earthquakeEval, protestEval, tsunamiEval, typhoonEval, riskEvaluation, room, designation, hazard, severity, endorsementNum, labOrRoom, prepDate, titlePreparedBy, namePreparedBy, titleNotedBy, nameNotedBy, remarks, isFaculty, isStudents, isPersonnel, isEquipment, abRectification, abSafetyPlan, actionVal, detailVal);

                objController.AddForm();
            }
            else if(funcType == 1)
            {

            }

        }

        public SERGForms(
            string sNumber,
            string nPreparedBy,
            string nNotedBy)
        {

        }
    }
}
