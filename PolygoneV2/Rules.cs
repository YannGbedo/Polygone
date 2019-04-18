using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PolygoneV2
{
    class Rules
    {
        /// <summary>
        /// Détermine le Type de base du Polygone
        /// </summary>
        /// <param name="NombreCote">Le nombre de coté</param>
        /// <returns>Retourne le Type du polygone</returns>
        public TypePolygone BaseType(int NombreCote)
        {
            switch (NombreCote) {
                case 0:
                case 1:
                case 2:
                    return TypePolygone.NonPolygone;
                case 3:
                    return TypePolygone.Triangle;
                case 4:
                    return TypePolygone.Quadrilatere;
                case 5:
                    return TypePolygone.Pentagone;
                default:
                    return TypePolygone.Autre;

            }
        }

        /// <summary>
        /// Détermine le type de triangle
        /// </summary>
        /// <param name="monPoly">Le polygone</param>
        /// <returns>Retourne le Type du Triangle</returns>
        public void TriangleType(Polygone monPoly)
        {

            if (monPoly.NombreCoteParallele > 0 || monPoly.NombreAngleDroit > 1 || monPoly.NombreCoteMemeTaille > 3)
            {
                monPoly.retour = "Ceci n'est pas un Polygone";
                monPoly.ColorDefinie = Polygone.Red;
            }
            else if (monPoly.NombreAngleDroit == 0)
            {
                switch (monPoly.NombreCoteMemeTaille)
                {
                    case 2:
                        monPoly.retour = "Ceci est un triangle Isoscele";
                        monPoly.ColorDefinie = Polygone.Green;
                        break;
                    case 3:
                        monPoly.retour = "Ceci est un triangle Equilateral";
                        monPoly.ColorDefinie = Polygone.Green;
                        break;
                    default:
                        monPoly.retour = "Ceci est un Triangle";
                        monPoly.ColorDefinie = Polygone.Green;
                        break;
                }
            }
            else
            {
                switch (monPoly.NombreCoteMemeTaille)
                {
                    case 2:
                        monPoly.retour = "Ceci est un triangle isocèle";
                        monPoly.ColorDefinie = Polygone.Green;
                        break;
                    case 3:
                        monPoly.retour = "Ceci n'est pas un Polygone";
                        monPoly.ColorDefinie = Polygone.Red;
                        break;
                    default:
                        monPoly.retour = "Ceci est un triangle Rectangle";
                        monPoly.ColorDefinie = Polygone.Green;
                        break;
                }

            }
        }

        /// <summary>
        /// Détermine le type de quadrilatere
        /// </summary>
        /// <param name="monPoly">Le polygone</param>
        /// <returns>Retourne le Type du Quadrilatere</returns>
        public void QuadrilatereType(Polygone monPoly)
        {
            if (monPoly.NombreCoteParallele > 4 || monPoly.NombreAngleDroit > 4 || monPoly.NombreCoteMemeTaille > 4 || monPoly.NombreCoteParallele > 4)
            {
                monPoly.retour = "Ceci n'est pas un Polygone";
                monPoly.ColorDefinie = Polygone.Red;
            }
            switch (monPoly.NombreCoteParallele)
            {
                case 1:
                case 3:
                default:
                    monPoly.retour = "Ceci n'est pas un Polygone";
                    monPoly.ColorDefinie = Polygone.Red;
                    break;
                case 4:
                    switch (monPoly.NombreCoteMemeTaille)
                    {
                        case 0:
                        case 1:
                        case 3:
                        default:
                            monPoly.retour = "Ceci n'est pas un Polygone";
                            monPoly.ColorDefinie = Polygone.Red;
                            break;
                        case 2:
                            if (monPoly.NombreAngleDroit == 4)
                            {
                                monPoly.retour = "Ceci est un rectangle";
                                monPoly.ColorDefinie = Polygone.Green;
                            } else if (monPoly.NombreAngleDroit == 0)
                            {
                                monPoly.retour = "Ceci est un parallélogramme quelconque";
                                monPoly.ColorDefinie = Polygone.Green;
                            } else
                            {
                                monPoly.retour = "Ceci n'est pas un Polygone";
                                monPoly.ColorDefinie = Polygone.Red;
                            }
                            break;
                        case 4:
                            if(monPoly.NombreAngleDroit == 0)
                            {
                                monPoly.retour = "Ceci est un losange";
                                monPoly.ColorDefinie = Polygone.Green;
                            } else if (monPoly.NombreAngleDroit == 4) {
                                monPoly.retour = "Ceci est un carré";
                                monPoly.ColorDefinie = Polygone.Green;
                            } else
                            {
                                monPoly.retour = "Ceci n'est pas un Polygone";
                                monPoly.ColorDefinie = Polygone.Red;
                            }
                            break;
                    }
                    break;
                case 2:
                    switch (monPoly.NombreCoteMemeTaille)
                    {
                        case 0:
                            if(monPoly.NombreAngleDroit == 2)
                            {
                                monPoly.retour = "Ceci est un trapèze rectangle";
                                monPoly.ColorDefinie = Polygone.Green;
                            } else if( monPoly.NombreAngleDroit == 0)
                            {
                                monPoly.retour = "Ceci est un trapèze quelconque";
                                monPoly.ColorDefinie = Polygone.Green;
                            } else
                            {
                                monPoly.retour = "Ceci n'est pas un Polygone";
                                monPoly.ColorDefinie = Polygone.Red;
                            }
                            break;
                        case 2:
                            if(monPoly.NombreAngleDroit == 0)
                            {
                                monPoly.retour = "Ceci est un trapèze isocèle";
                                monPoly.ColorDefinie = Polygone.Green;
                            } else
                            {
                                monPoly.retour = "Ceci n'est pas un Polygone";
                                monPoly.ColorDefinie = Polygone.Red;
                            }
                            break;
                        case 1:
                        case 3:
                        case 4:
                        default:
                            monPoly.retour = "Ceci n'est pas un Polygone";
                            monPoly.ColorDefinie = Polygone.Red;
                            break;



                    }
                    break;
                case 0:
                    switch (monPoly.NombreCoteMemeTaille)
                    {
                        case 1:
                        case 4:
                        default:
                            monPoly.retour = "Ceci n'est pas un Polygone";
                            monPoly.ColorDefinie = Polygone.Red;
                            break;
                        case 0:
                            if(monPoly.NombreAngleDroit > 2)
                            {
                                monPoly.retour = "Ceci n'est pas un Polygone";
                                monPoly.ColorDefinie = Polygone.Red;
                            } else
                            {
                                monPoly.retour = "Ceci est un quadrilatère quelconque";
                                monPoly.ColorDefinie = Polygone.Green;
                            }
                            break;
                        case 2:
                            if (monPoly.NombreAngleDroit > 1)
                            {
                                monPoly.retour = "Ceci n'est pas un Polygone";
                                monPoly.ColorDefinie = Polygone.Red;
                            }
                            else
                            {
                                monPoly.retour = "Ceci est un quadrilatère quelconque";
                                monPoly.ColorDefinie = Polygone.Green;
                            }
                            break;
                        case 3:
                            if (monPoly.NombreAngleDroit > 1)
                            {
                                monPoly.retour = "Ceci n'est pas un Polygone";
                                monPoly.ColorDefinie = Polygone.Red;
                            }
                            else
                            {
                                monPoly.retour = "Ceci est un quadrilatère quelconque";
                                monPoly.ColorDefinie = Polygone.Green;
                            }
                            break;
                    }
                    break;

            }

        }


        public void PentagoneType(Polygone monPoly)
        {
            bool isPentagone = false;
            if (monPoly.NombreCoteParallele > 5 || monPoly.NombreAngleDroit > 5 || monPoly.NombreCoteMemeTaille > 5 || monPoly.NombreCoteParallele > 5)
            {
                isPentagone = false;
            }
            else
            {
                switch (monPoly.NombreCoteMemeTaille){
                    case 1:
                    case 2:
                    case 0:
                        if (monPoly.NombreAngleDroit < 4 && monPoly.NombreCoteParallele < 4)
                            isPentagone = true;
                        break;
                    case 3:
                        if (monPoly.NombreCoteParallele < 3 && monPoly.NombreAngleDroit < 3)
                            isPentagone = true;
                        break;
                    case 4:
                    case 5:
                        if (monPoly.NombreCoteParallele == 0 && monPoly.NombreAngleDroit == 0)
                            isPentagone = true;
                        break;
                    
                    
                }
                
            }

            if (isPentagone)
            {
                monPoly.retour = "Ceci est un pentagone";
                monPoly.ColorDefinie = Polygone.Green;
            }
            else
            {
                monPoly.retour = "Ceci n'est pas un polygone";
                monPoly.ColorDefinie = Polygone.Red;
            }
        }
    }

}
