using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SharpShapes
{
    public abstract class Shape
    {
        // Width, Height, Perimeter, Area, BorderColor, FillColor, NumberOfSides
        /// <summary>
        /// Specifies the interior color of the shape.
        /// </summary>
        public Color FillColor { get; set; }

        /// <summary>
        /// Specifies the color of the border of the shape, when drawn.
        /// </summary>
        public Color BorderColor { get; set; }
        
        /// <summary>
        /// The number of sides of this shape.
        /// </summary>
        public virtual int SidesCount { get;  }

        /// <summary>
        /// Calculates the area of the shape.
        /// </summary>
        /// <returns>the area of the shape</returns>
        public abstract decimal Area() {}
        
        /// <summary>
        ///Calculates the perimetert of the shape 
        /// </summary>
        /// <returns>the perimeter of the shape</returns>
        public abstract int Perimeter() {}

        /// <summary>
        /// Scales the shape in size
        /// </summary>
        /// <param name="percent">the percentage by which to scale the shape</param>
        public abstract void scale(int percent) { }
    }
}
