using System;
using System.Text;

namespace NeuerOrdner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(compute(" 1 + 2 +4+ 1"));

        }

        static String compute(String param){
			//truncate blanks
        	param = param.Replace(" ",String.Empty);




        	String summe = getTeilSumme(param);


        	return summe;
        }



        static String getTeilSumme(String param){

        		int ergebnis;
        		ergebnis = 0;
        		char[] ch = param.ToCharArray();
        		for(int i = 0; i< ch.Length; i++)
        		{
        			//Console.WriteLine(ch[i]);
        			if(Char.IsNumber(ch[i]))
        			{
        				ergebnis += Convert.ToInt32(ch[i]);
        			}
        		}
        		param = param + "erbenis = " + ergebnis.ToString();
        	return param;
        }
    }
    
}
