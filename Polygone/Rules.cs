using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygone
{
    class Rules
    {
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



            }
            return TypePolygone.Carre;
        }
    }

    enum TypePolygone{
        NonPolygone,
        Triangle,
        TriangleQuelconque,
        TriangleIsocele,
        TriangleRectangle,
        TriangleRectangleIsocele,
        TriangleEquilateral,
        Quadrilatere,
        QuadrilatereQuelconque,
        Trapeze,
        Parallelogramme,
        Losange,
        Rectangle,
        Carre,
        Pentagone

    }
}
