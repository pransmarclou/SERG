using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERG.Model
{
    class RiskEval
    {
        //Data
        private string serialNum { get; set; }

        private short fireEval { get; set; }

        private short smokeEval { get; set; }

        private short bombThreatEval { get; set; }

        private short earthquakeEval { get; set; }

        private short protestEval { get; set; }

        private short tsunamiEval { get; set; }

        private short typhoonEval { get; set; }


        //Constructors

        public RiskEval(string sNumber)
        {
            serialNum = sNumber;
        }
        public RiskEval(string sNumber, short fEval, short sEval, short btEval, short eEval, short pEval, short tsuEval, short tyEval)
        {
            serialNum = sNumber;
            fireEval = fEval;
            smokeEval = sEval;
            bombThreatEval = btEval;
            earthquakeEval = eEval;
            protestEval = pEval;
            tsunamiEval = tsuEval;
            typhoonEval = tyEval;
        }

    }
}
