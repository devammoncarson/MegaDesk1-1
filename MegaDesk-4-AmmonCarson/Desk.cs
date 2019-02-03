using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_AmmonCarson
{
    class Desk
    {

        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public int NumDrawers { get; set; }

        public enum SurfaceMaterial
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }

        public SurfaceMaterial Material { get; set; }
    }
}
