using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace RoboLib
{
    public class Robot
    {
        private int _x;
        private int _y;
        private int _radius;
        private Color _color;
        private int _direction;
        private int _width;
        private int _height;
        private int _speed;
        private bool moved = true;
        private Timer timer;
        private const int MAXSPEED = 10;

        public Robot(int radius, Color color,int width, int height, int x, int y, int direction)
        {
            if(radius < 10)
                throw new Exception("Radius has to be at least 10 pixels!");
            if (width < 2*radius || height < 2*radius)
                throw new Exception("Room size needs to be at least double robot radius!");
            if(x - radius<0||y-radius<0||x+radius>width||y+radius>height)
                throw new Exception("Robot can't be placed!");
            if (direction < 1 || direction > 4)
                throw new Exception("Valid directions: 1..North, 2..East, 3..South, 4..West");
            _x = x;
            _y = y;
            _radius = radius;
            _direction = direction;
            _width = width;
            _height = height;
            _speed = 5;
            _color = color;
            timer = new Timer();
        }
        public Robot(int radius, Color color, int width, int height)
        {
            if (radius < 10)
                throw new Exception("Radius has to be at least 10 pixels!");
            _radius = radius;
            _x = radius;
            _y = radius;
            if (width < 2 * radius || height < 2 * radius)
                throw new Exception("Room size needs to be at least robot size!");
            if (_x - radius < 0 || _y - radius < 0 || _x + radius > width || _y + radius > height)
                throw new Exception("Robot can't be placed!");
            _direction = 2;
            _width = width;
            _height = height;
            _speed = 5;
            _color = color;
            timer = new Timer();
        }
        public int X
        {
            get
            {
                return _x;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
        }
        public int Radius
        {
            get
            {
                return _radius;
            }
        }
        public Color Colour
        {
            get
            {
                return Colour;
            }
        }
        public int Direction
        {
            get
            {
                return _direction;
            }
        }
        public int Width
        {
            get
            {
                return _width;
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
        }
        public int Speed
        {
            get
            {
                return _speed;
            }
        }
        public override string ToString()
        {
            string dir;
            if (_direction == 1)
                dir = "North";
            else if (_direction == 2)
                dir = "East";
            else if (_direction == 3)
                dir = "South";
            else dir = "West";
            return ("Robot X:" + _x + " Y:" + _y + " Speed:" + _speed + " Direction:" + dir);
        }
        public void RotateRight()
        {
            if (_direction < 4)
            {
                _direction++;
            }
            else _direction = 1;
        }
        public void RotateLeft()
        {
            if (_direction > 1)
            {
                _direction--;
            }
            else _direction = 4;
        }
        public void SpeedUp()
        {
            if(_speed < MAXSPEED)
            _speed++;
        }
        public void SpeedDown()
        {
            if (_speed > 0)
                _speed--;
        }
        public void Move()
        {
            moved = true;
            if(_direction == 1)
            {
                if (_y - _speed - _radius > 0)
                    _y -= _speed;
                else
                {
                    _y = _radius;
                    moved = false;
                }
            }
            else if(_direction == 2)
            {
                if (_x + _speed + _radius < _width)
                    _x += _speed;
                else
                {
                    _x = _width - _radius;
                    moved = false;
                }
            }
            else if(_direction == 3)
            {
                if (_y + _speed + _radius < _height)
                    _y += _speed;
                else
                {
                    _y = _height - _radius;
                    moved = false;
                }
            }
            else
            {
                if (_x - _speed - _radius > 0)
                    _x -= _speed;
                else
                {
                    _x = _radius;
                    moved = false;
                }
            }
        }
        public void PanicStop()
        {
            _speed = 0;
        }
        public void StartAuto()
        {
            timer.Start();
            timer.Interval = 50;
            timer.Tick += MoveAuto;
        }

        private int i=0;
        private int RandomVal = 20;
        private void MoveAuto(object sender, EventArgs e)
        {
            i++;
            Random Rand = new Random();
            if (i == RandomVal)
            {
                RandomVal=Rand.Next(5, 15);

                if (Rand.Next(1, 3) == 1)
                    RotateRight();
                else RotateLeft();
                i = 0;
            }
            Move();
            if (!moved)
                RotateRight();

            
        }
        public void DrawRobot(Graphics dev)
        {
            Brush B1 = new SolidBrush(_color);
            dev.FillEllipse(B1, _x - _radius, _y - _radius, _radius * 2, _radius * 2);
            dev.DrawEllipse(Pens.Black,_x-_radius,_y-_radius,_radius*2,_radius*2);
            switch (_direction)
            {
                case 1:
                    dev.DrawLine(Pens.Black, _x, _y - _radius, _x, _y);
                    break;
                case 2:
                    dev.DrawLine(Pens.Black, _x, _y, _x+_radius, _y);
                    break;
                case 3:
                    dev.DrawLine(Pens.Black, _x, _y + _radius, _x, _y);
                    break;
                default:
                    dev.DrawLine(Pens.Black, _x, _y, _x - _radius, _y);
                    break;
            }
        }
        public void StopAuto()
        {
            timer.Stop();
            i = 0;
        }
    }
}
