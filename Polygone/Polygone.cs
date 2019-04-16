using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygone
{


    class Polygone
    {
        public static void Main()
        {
            App myapp = new App();
            myapp.Run();
        }

        public int NombreCote { get; set; }
        public int NombreAngleDroit { get; set; }
        public int NombreCoteMemeTaille { get; set; }
        public int NombreCoteParallele { get; set; }

        public Polygone(int _cote, int _angle, int _taille, int _parallele)
        {
            NombreCote = _cote;
            NombreAngleDroit = _angle;
            NombreCoteMemeTaille = _taille;
            NombreCoteParallele = _parallele;
        }
    }
}
