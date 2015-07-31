using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGBStats
{
    class EgbCsglPair
    {
        static string log = "";
        public EGBMatch egbm;
        public CSGLMatch csglm;
        public double oddsAdiff;
        public double oddsBdiff;
        public EgbCsglPair()
        {
        }
        public EgbCsglPair(EGBMatch egbm, CSGLMatch csglm)
        {
            this.egbm = egbm;
            this.csglm = csglm;
            oddsAdiff = egbm.coefB / (egbm.coefA + egbm.coefB) - csglm.oddsA;
            oddsBdiff = egbm.coefA / (egbm.coefA + egbm.coefB) - csglm.oddsB;
        }
    }
}
