using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class AsteroidsGame
    {
        private Asteroid[] _asteroids;
        public AsteroidsGame()
        {
            _asteroids = new Asteroid[5];
            _asteroids[0] = new Asteroid(100, 200, -2, -4);
            _asteroids[1] = new Asteroid(-50, 100, -1, +3);
            _asteroids[2] = new Asteroid(0, 0, 2, 1);
            _asteroids[3] = new Asteroid(400, -100, -3, -1);
            _asteroids[4] = new Asteroid(200, -300, 0, 3);
        }

        public void Run()
        {
            while (true)
            {
                foreach (Asteroid asteroid in _asteroids)
                {
                    asteroid.Update();
                }
            }
        }
    }
}
