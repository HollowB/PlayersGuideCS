using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    public class Asteroid
    {
        public Coordinate Position { get; private set; }
        public Coordinate Velocity { get; private set; }
        /*public float PositionX { get; private set; }
        public float PositionY { get; private set; }
        public float VelocityX { get; private set; }
        public float VelocityY { get; private set; }*/

        public Asteroid(float posX, float posY, float velX, float velY)
        {
            Position = new Coordinate(posX, posY);
            Velocity = new Coordinate(velX, velY);
            
            /*PositionX = posX;
            PositionY = posY;
            VelocityX = velX;
            VelocityY = velY;*/
        }

        public void Update()
        {
            Position.X += Velocity.X;
            Position.X += Velocity.X;
        }

    }
}
