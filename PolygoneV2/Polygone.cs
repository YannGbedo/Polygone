using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PolygoneV2
{
    class Polygone
    {

        public readonly static Color Green = Color.FromRgb(0, 200, 0);
        public readonly static Color Red = Color.FromRgb(200, 33, 33);

        public static List<Polygone> PolygoneConnue = new List<Polygone>();

        public int NombreCote { get;  set; }
        public int NombreAngleDroit { get; set; }
        public int NombreCoteMemeTaille { get;  set; }
        public int NombreCoteParallele { get;  set; }

        //Retour
        public Color ColorDefinie { get; set; }
        public string retour { get; set; }

        [JsonConstructor]
        private Polygone() { }
        public Polygone(int _cote, int _angle, int _taille, int _parallele)
        {
            NombreCote = _cote;
            NombreAngleDroit = _angle;
            NombreCoteMemeTaille = _taille;
            NombreCoteParallele = _parallele;
        }

        public void Traitement()
        {
            Rules MesRegles = new Rules();
            TypePolygone Type = MesRegles.BaseType(NombreCote);
            
            switch (Type)
            {
                case TypePolygone.Triangle:
                    MesRegles.TriangleType(this);
                    break;
                case TypePolygone.Quadrilatere:
                    MesRegles.QuadrilatereType(this);
                    break;
                case TypePolygone.Pentagone:
                    retour = "Ceci est un Pentagone";
                    ColorDefinie = Green;
                    break;
                default:
                    retour = "Ceci n'est pas un Polygone";
                    ColorDefinie = Red;
                    break;
            }
        }

        public override string ToString() => retour;

    }
}
