using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTank
{
    public partial class FormTank : Form
    {
        private ITransport armoredVehicle;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormTank()
        {
            InitializeComponent();
        }
        public void SetArmoredVehicle(ITransport armoredVehicle)
        {
            this.armoredVehicle = armoredVehicle;
            Draw();
        }
        /// <summary>
        /// Метод отрисовки 
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTank.Width, pictureBoxTank.Height);
            Graphics gr = Graphics.FromImage(bmp);
            armoredVehicle.DrawTransport(gr);
            pictureBoxTank.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    armoredVehicle.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    armoredVehicle.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    armoredVehicle.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    armoredVehicle.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}