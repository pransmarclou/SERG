﻿using System;
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


        public SERGForms(
            //riskeval
            out string sNumber,
            out short fEval,
            out short sEval,
            out short btEval,
            out short eEval,
            out short pEval,
            out short tsuEval,
            out short tyEval,

            //sereport
            out string rEval,
            out string rm,
            out string desig,
            out string haz,
            out string sev,
            out string endNum,
            out bool lOrR,
            out DateTime prepD,
            out string titlePB,
            out string namePB,
            out string titleNB,
            out string nameNB,

            //whoisatrisk
            out bool isFac,
            out bool isStud,
            out bool isPer,
            out bool isEquip,

            //actionbox and otehrs
            out bool abRec,
            out bool abSafety,
            out string actVal,
            out string detVal)
        {

            sNumber = serialNum;

            //risk eval
            fEval = fireEval;
            sEval = smokeEval;
            btEval = bombThreatEval;
            eEval = earthquakeEval;
            pEval = protestEval;
            tsuEval = tsunamiEval;
            tyEval = typhoonEval;

            //sereport
            rEval = riskEvaluation;
            rm = room;
            desig = designation;
            haz = hazard;
            sev = severity;
            endNum = endorsementNum;
            lOrR = labOrRoom;
            prepD = prepDate;
            titlePB = titlePreparedBy;
            namePB = namePreparedBy;
            titleNB = titleNotedBy;
            nameNB = nameNotedBy;

            //whoisatrisk
            isFac = isFaculty; 
            isStud = isStudents;
            isPer = isPersonnel;
            isEquip = isEquipment;

            //actionboxandothers
            abRec = abRectification;
            abSafety = abSafetyPlan;
            actVal = actionVal;
            detVal = detailVal;



        }

        public SERGForms(
            //riskeval
            string sNumber, 
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
    }
}