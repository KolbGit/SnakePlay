namespace SnakePlay
{
    public partial class Form1 : Form
    {
        private int _wight = 900;
        private int _height = 800;
        private int _sizeOfSides = 40;

        public Form1()
        {
            InitializeComponent();
            this.Width = _wight;
            this.Height = _height;
            _generateMap();
            this.KeyDown += new KeyEventHandler(OKP);
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

        private void OKP(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    cube.Location = new Point(cube.Location.X + 20, cube.Location.Y);
                    break;
                case "Left":
                    cube.Location = new Point(cube.Location.X - 20, cube.Location.Y);
                    break;
                case "Up":
                    cube.Location = new Point(cube.Location.X, cube.Location.Y - 20);
                    break;
                case "Down":
                    cube.Location = new Point(cube.Location.X, cube.Location.Y + 20);
                    break;
            }
        }
    }
}