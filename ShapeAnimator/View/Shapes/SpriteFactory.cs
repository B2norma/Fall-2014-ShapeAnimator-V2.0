﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    static class SpriteFactory
    {
        public static ShapeSprite GenerateRandomSprite(Shape tempShape,Random randomizer)
        {
            int tempRandomNumber = randomizer.Next(0, 3);
            switch (tempRandomNumber)
            {
                case 0:
                    return new CircleSprite(tempShape);
                case 1:
                    return new RectangleSprite(tempShape);
                case 2:
                    return new LRectangleSprite(tempShape);
                default:
                    return null;
            }
        }
    }
}