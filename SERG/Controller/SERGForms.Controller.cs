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

namespace SERG.Controller
{
    class SERGForms
    {
        //connection string
        private string cnString = ConfigurationManager.ConnectionStrings["cn_SERG"]?.ConnectionString;
       



        //Constructor
        public SERGForms(int functionType)
        {

           
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
