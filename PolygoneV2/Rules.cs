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
        public TypeTriangle TriangleType(Polygone monPoly)
        {
            if (monPoly.NombreCoteParallele > 0 || monPoly.NombreAngleDroit > 1 || monPoly.NombreCoteMemeTaille > 3)
                return TypeTriangle.NonPolygone;
            else if (monPoly.NombreAngleDroit == 0)
            {
                switch (monPoly.NombreCoteMemeTaille)
                {
                    case 2:
                        return TypeTriangle.TriangleIsocele;
                    case 3:
                        return TypeTriangle.TriangleEquilateral;
                    default:
                        return TypeTriangle.TriangleQuelconque;
                }
            }
            else
            {
                switch (monPoly.NombreCoteMemeTaille)
                {
                    case 2:
                        return TypeTriangle.TriangleRectangleIsocele;
                    case 3:
                        return TypeTriangle.NonPolygone;
                    default:
                        return TypeTriangle.TriangleRectangle;
                }
                    
            }
            return TypeTriangle.NonPolygone;
        }

        /// <summary>
        /// Détermine le type de quadrilatere
        /// </summary>
        /// <param name="monPoly">Le polygone</param>
        /// <returns>Retourne le Type du Quadrilatere</returns>
        public TypeQuadrilatere QuadrilatereType(Polygone monPoly)
        {
            if (monPoly.NombreCoteParallele > 4 || monPoly.NombreAngleDroit > 4 || monPoly.NombreCoteMemeTaille > 4)
                return TypeQuadrilatere.NonPolygone;

            return TypeQuadrilatere.Carre;
        }
    }

}
