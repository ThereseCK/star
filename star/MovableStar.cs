﻿using System;
using System.Collections.Generic;
using System.Text;

namespace star
{
    public class MovableStar : Star
    {
        private int _speedX;
        private int _speedY;

        public MovableStar(int x, int y, int speedX, int speedY, int phase) : base(x, y, phase)
        {
            _speedX = _speedX;
            _speedY = _speedY;
        }

        public MovableStar(Random random) : base(random)
        {
            _speedY = random.Next(-1, 2);
            _speedX = random.Next(-1, 2);
        }

        public override void Update()
        {
            base.Update();
            var windowWidth = Console.WindowWidth;
            var windowHeight = Console.WindowHeight;

            if (_x <= 1) _speedX = 1;
            if (_x >= windowWidth - 1) _speedX = -1;
            if (_y <= 1) _speedY = 1;
            if (_y >= windowHeight - 1) _speedY = -1;
            _x += _speedX;
            _y += _speedY;
        }
    }
}
