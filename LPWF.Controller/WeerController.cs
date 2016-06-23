using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPWF.Controller
{

    public class WeerController
    {
        InputOutputController InputController = new InputOutputController();

        public IEnumerable<string> ReturnVerwachting()
        {
            List<string[]> stringarraylist = InputController.ReadFromCSV().ToList();
            foreach (string[] item in stringarraylist)
            {
                yield return item[0] + ": " + WeersVerwachting(Convert.ToInt32(item[1]), Convert.ToInt32(item[2])).ToString();
            }
            yield break;

        }
        public double WeersVerwachting(int temperatuur, int windsnelheid)
        {
            return 33 + (temperatuur-33)*(0.474 + 0.454 * Math.Sqrt(windsnelheid) - 0.0454*windsnelheid);
        }
    }
}
