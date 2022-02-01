using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClosedXML.Excel.CalcEngine.Functions
{
    internal static class PowerQuery
    {
        public static void Register(CalcEngine ce) {
            // https://support.microsoft.com/en-us/office/cubeset-function-5b2146bd-62d6-4d04-9d8f-670e993ee1d9
            ce.RegisterFunction("CUBESET", 2, CubeSet);
            ce.RegisterFunction("CUBESETCOUNT", 1, CubeSetCount);
            ce.RegisterFunction("CUBERANKEDMEMBER", 3, CubeRankedMember);
            ce.RegisterFunction("CUBEVALUE", 3, CubeValue);
        }

        private static object CubeSet(List<Expression> parms) {
            return "";
        }

        private static object CubeSetCount(List<Expression> parms) {
            return "";
        }
        private static object CubeRankedMember(List<Expression> parms) {
            return "";
        }
        private static object CubeValue(List<Expression> parms) {
            return "";
        }

    }
}
