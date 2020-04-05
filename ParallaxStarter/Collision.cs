using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ParallaxStarter
{
    public static class Collision
    {
        public static bool CollidesWith(this BoundingRectangle a, BoundingRectangle b)
        {
            return !((a.X > a.X + b.Width)
                || (a.X + a.Width < b.X)
                || (a.Y > b.Y + b.Height)
                || (a.Y + a.Height < b.Y)
                );
        }

        public static bool CollidesWith(this Vector2 v, Vector2 other)
        {
            return v == other;
        }

        public static bool CollidesWith(this Vector2 v, BoundingRectangle r)
        {
            return (r.X <= v.X && v.X <= r.X + r.Width) && (r.Y <= v.Y && v.Y <= r.Y + r.Height);
        }

        public static bool CollidesWith(this BoundingRectangle r, Vector2 v)
        {
            return v.CollidesWith(r);
        }


    }
}
