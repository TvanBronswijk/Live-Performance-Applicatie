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

        public IEnumerable<string[]> ReadFromCSV()
        {
            List<string> stringlist = Read("input.csv").ToList();
            foreach (string S in stringlist)
            {
                yield return S.Split(';');
            }
            yield break;
        }

        private void Write(string ToWrite)
        {
            using (StreamWriter wrt = new StreamWriter("output.txt"))
            {
                wrt.Write(ToWrite);
            }
                
        }

        private IEnumerable<string> Read(string location)
        {
            using (StreamReader red = new StreamReader(location))
            {
                while (!red.EndOfStream)
                {
                    yield return red.ReadLine();
                }
                yield break;
            }
        }
    }
}
