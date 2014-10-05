﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAnimator.Model.Shapes
{
    class Circle : Shape
    {
        

        public Circle(Point Location, int tempDirection, int tempSpeedX, int tempSpeedY) : base(Location, tempDirection, tempSpeedX, tempSpeedY)
        {
            width = 100;
            height = 100;
        }

        /// <summary>
        ///     Default constructor
        /// </summary>


        public override void Move()
        {

            return;
        }

    }
}
