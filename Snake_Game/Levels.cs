using Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class Levels : Figure
    {
        List<Figure> letlist;
        public Levels()
        {
            Random random = new Random();
            int count = random.Next(2, 4);
            letlist = new List<Figure>();
        }

        internal new bool IsHit(Figure figure)
        {
            foreach (var wall in letlist)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public new void Draw()
        {
            foreach (var wall in letlist)
            {
                wall.Draw();
            }
        }
    }
}
