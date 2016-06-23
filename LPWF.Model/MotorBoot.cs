using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPWF.Model
{
    public class MotorBoot : Boot
    {
        public int TankInhoud { get; set; }
        public int ActieRadius { get { return TankInhoud * 15; } }

        public override string ToString()
        {
            return Naam + $" [Actieradius:{ActieRadius}]";
        }
    }
}
