using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Worker
    {
        public String compute(String param)
        {
            param = param.Replace(" ", String.Empty);//truncate blanks
            String summe = getTeilSumme(param);
            return summe;
        }
        public String getTeilSumme(String param)
        {
            int ergebnis = 0;
            int ersteZahl = getErsteOderZweiteZahl(param, 0);
            int zweiteZahl = getErsteOderZweiteZahl(param,2);
            string operation = getOperator(param);

            if(operation == "+")
            {
                ergebnis = ersteZahl
                        + zweiteZahl;
            }else if (operation == "-")
            {
                ergebnis = Convert.ToInt32(param.Substring(0, 1))
                        - Convert.ToInt32(param.Substring(2, 1));
            }
            else if (operation == "*")
            {
                ergebnis = Convert.ToInt32(param.Substring(0, 1))
                        * Convert.ToInt32(param.Substring(2, 1));
            }
            else if (operation == "/")
            {
                ergebnis = Convert.ToInt32(param.Substring(0, 1))
                        / Convert.ToInt32(param.Substring(2, 1));
            }
            return ergebnis.ToString();
        }

        private string getOperator(string param)
        {
            Regex rx = new Regex(@"[-+\/*]");
            MatchCollection matches = rx.Matches(param);
            return matches[0].Value;
        }

        private int getErsteOderZweiteZahl(string param, int idx)
        {
            Regex rx = new Regex(@"\d*");
            MatchCollection matches = rx.Matches(param);
            return Convert.ToInt32(matches[idx].Value);
        }
    }
}
