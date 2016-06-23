using LPWF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LPWF.Controller
{
    public class InputOutputController
    {
        public void WriteToTXT(Huurcontract ToWrite)
        {
            Write(ToWrite.ToString());
        }

        private void Write(string ToWrite)
        {
            using (StreamWriter wrt = new StreamWriter("output.txt"))
            {
                wrt.Write(ToWrite);
            }
                
        }
    }
}
