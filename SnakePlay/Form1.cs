using System.CodeDom.Compiler;

namespace SnakePlay
{
    public partial class Form1 : Form
    {
        private int rI, rJ;
        private PictureBox fruit;
        private int dirX, dirY;
        private int _wight = 900;
        private int _height = 800;
        private int _sizeOfSides = 40;

        public Form1()
        {
            InitializeComponent();
            this.Width = _wight;
            this.Height = _height;
            dirX = 1;
            dirY = 0;
            fruit = new PictureBox();
            fruit.BackColor = Color.Yellow;
            _generateMap();
            _generateFruit();
            fruit.Size = new Size(_sizeOfSides, _sizeOfSides);
            timer.Tick += new EventHandler(_update);
            timer.Interval = 500;
            timer.Start();
            this.KeyDown += new KeyEventHandler(OKP);
        }

        private void _generateFruit()
        {
            Random r = new Random();
            rI = r.Next(0, _wight - _sizeOfSides);
            int tempI = rI % _sizeOfSides;
            rI -= tempI;
            rJ = r.Next(0, _wight - _sizeOfSides);
            int tempJ = rJ % _sizeOfSides;
            rJ -= tempJ;
            fruit.Location = new Point(rI, rJ);
            this.Controls.Add(fruit);
        }

        private void _generateMap()
        {
            for (int i = 0; i < _wight / _sizeOfSides; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(0, _sizeOfSides * i);
                pic.Size = new Size(_wight - 100, 1);
                this.Controls.Add(pic);
            }
            for (int i = 0; i <= _height / _sizeOfSides; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(_sizeOfSides * i, 0);
                pic.Size = new Size(1, _wight);
                this.Controls.Add(pic);
            }
        }

        private void _update(Object myObject, EventArgs eventArgs)
        {
            cube.Location = new Point(cube.Location.X + dirX * _sizeOfSides, cube.Location.Y + dirY * _sizeOfSides);
        }

        private void OKP(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    dirX = 1;
                    dirY = 0;
                    break;
                case "Left":
                    dirX = -1;
                    dirY = 0;
                    break;
                case "Up":
                    dirY = -1;
                    dirX = 0;
                    break;
                case "Down":
                    dirY = 1;
                    dirX = 0;
                    break;
            }
        }
    }
}