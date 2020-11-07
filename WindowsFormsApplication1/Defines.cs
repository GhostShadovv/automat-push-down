using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class Defines
    {
        //"../../Gramatica.txt";
        public static string initial_path = System.IO.Directory.GetCurrentDirectory() + @"\Gramatica.txt";
    }

    public class Data
    {
        public string strKey { get; set; }
        public string strProduction { get; set; }

        public Data(string strValue1, string strValue2)
        {
            strKey = strValue1;
            strProduction = strValue2;
        }
    }
    public class Actiuni
    {
        public Actiuni(int intValue_of_Status_Member, string strValue_of_Terminal, string strValue_of_Data)
        {
            intStatusNumber = intValue_of_Status_Member;
            strTerminal = strValue_of_Terminal;
            strData = strValue_of_Data;
        }
        public int intStatusNumber { get; set; }
        public string strTerminal { get; set; }
        public string strData { get; set; }
    }

    public class Salt
    {
        public Salt(int intValue1, string strValue1, int intValue2)
        {
            intStatusNumber = intValue1;
            intData = intValue2;
            strData = strValue1;
        }
        public int intStatusNumber { get; set; }
        public int intData { get; set; }
        public string strData { get; set; }
    }
}
