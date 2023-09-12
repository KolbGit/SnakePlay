namespace SnakePlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(OKP);
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
                    cube.Location = new Point(cube.Location.X , cube.Location.Y - 20);
                    break;
                case "Down":
                    cube.Location = new Point(cube.Location.X , cube.Location.Y + 20);
                    break;
            }
        }
    }
}