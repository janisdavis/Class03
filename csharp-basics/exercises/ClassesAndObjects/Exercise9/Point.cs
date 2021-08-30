﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise9
{
    class Point
    {
        public int _x;
        public int _y;

        public Point(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
    }

    class SwapTest
    {
        public static void SwapPoints(ref Point x, ref Point y)
        {
            Point temp = x;
            x = y;
            y = temp;
        }
    }
}
