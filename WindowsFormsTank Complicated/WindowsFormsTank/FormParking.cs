using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTank
{
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly Parking<ArmoredVehicle, GunsFirstStyle> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ArmoredVehicle, GunsFirstStyle>(pictureBoxParking.Width,
           pictureBoxParking.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать транспорт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonParkingArmoredVehicle_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var armoredVehicle = new ArmoredVehicle(100, 1000, dialog.Color);

                if (parking + armoredVehicle)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать гоночный автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonParkingTank_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogParking = new ColorDialog();
                if (dialogParking.ShowDialog() == DialogResult.OK)
                {
                    Random rnd = new Random();
                    int numberDopGun = Convert.ToInt32(comboBoxNumberDopGun.SelectedItem);
                    var armoredVehicle = new Tank(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green, Color.Brown, true, true, true, true, numberDopGun, FormaOrudiya());
                    button_GunsFirstStyle.Enabled = true;
                    button_GunsSecondStyle.Enabled = true;
                    button_GunsThirdStyle.Enabled = true;
                    if (parking + armoredVehicle)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }

        }


        private void buttonGunsStyle_Click(object sender, EventArgs e)
        {
            if (sender == button_GunsFirstStyle)
            {
                button_GunsSecondStyle.Enabled = false;
                button_GunsThirdStyle.Enabled = false;
            }
            else if (sender == button_GunsSecondStyle)
            {
                button_GunsFirstStyle.Enabled = false;
                button_GunsThirdStyle.Enabled = false;
            }
            else
            {
                button_GunsSecondStyle.Enabled = false;
                button_GunsFirstStyle.Enabled = false;
            }
        }

        private int FormaOrudiya()
        {
            if (button_GunsFirstStyle.Enabled == true)
            {
                return 0;
            }
            else if (button_GunsSecondStyle.Enabled == true)
            {
                return 1;
            }
            else
            {
                return 2;
            }

        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetVehicle_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxParkingNumber.Text != "")
            {
                var armoredVehicle = parking - Convert.ToInt32(maskedTextBoxParkingNumber.Text);
                if (armoredVehicle != null)
                {
                    FormTank form = new FormTank();
                    form.SetArmoredVehicle(armoredVehicle);
                    form.ShowDialog();
                }
                Draw();
            }
        }
        private void buttonSvobodMesta_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxParkingNumber.Text != "")
            {
                int index = Convert.ToInt32(maskedTextBoxParkingNumber.Text);
                if (parking >= index)
                {
                    MessageBox.Show("Свободных мест в депо >= " + index);
                }
                else if (parking <= index)
                {
                    MessageBox.Show("Свободных мест в депо <= " + index);
                }
            }

        }
    }
}