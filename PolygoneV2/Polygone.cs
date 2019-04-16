using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygoneV2
{
    class Polygone
    {

        public int NombreCote { get; set; }
        public int NombreAngleDroit { get; set; }
        public int NombreCoteMemeTaille { get; set; }
        public int NombreCoteParallele { get; set; }

        public string retour { get; set; }

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
                    switch (MesRegles.TriangleType(this)){
                        case TypeTriangle.TriangleEquilateral:
                            retour = "Ceci est un triangle Equilateral";
                            break;
                        case TypeTriangle.TriangleIsocele:
                            retour = "Ceci est un triangle Isoscele";
                            break;
                        case TypeTriangle.TriangleRectangle:
                            retour = "Ceci est un triangle rectangle";
                            break;
                        case TypeTriangle.TriangleRectangleIsocele:
                            retour = "Ceci est un triangle Rectangle Isocele";
                            break;
                        case TypeTriangle.TriangleQuelconque:
                            retour = "Ceci est un Triangle";
                            break;
                        default:
                            retour = "Ceci n'est pas un Polygone";
                            break;
                    }
                    break;
                case TypePolygone.Quadrilatere:
                    break;
                default:
                    retour = "Ceci n'est pas un Polygone";
                    break;
            }
                
        }

        public override string ToString() => retour;

    }
}
