﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine upLine = new HorizontalLine(1, mapWidth - 2, 4, 'x', 0);
            HorizontalLine downLine = new HorizontalLine(1, mapWidth - 2, mapHeight - 1, 'x', 0);
            VerticalLine leftLine = new VerticalLine(5, mapHeight - 1, 0, '|', 0);
            VerticalLine rightLine = new VerticalLine(5, mapHeight - 1, mapWidth - 1, '|', 0);

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
