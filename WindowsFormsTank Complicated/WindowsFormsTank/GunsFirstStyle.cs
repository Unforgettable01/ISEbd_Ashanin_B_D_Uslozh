using System.Drawing;

namespace WindowsFormsTank
{
    class GunsFirstStyle : IDopGun
    {
        private Enumeration _numberDopGun;

        public int SetNumberDopGun { set => _numberDopGun = (Enumeration)value; }
        public Color DopColor { private set; get; }

        public GunsFirstStyle(int gun, Color dopColor)
        {
            SetNumberDopGun = gun;
            DopColor = dopColor;
        }

        public void DrawDopGun(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {

            if (_numberDopGun == Enumeration.One)
            {
                DrawDopGun_1(g, dopColor, _startPosX, _startPosY);
            }

            if (_numberDopGun == Enumeration.Two)
            {
                DrawDopGun_2(g, dopColor, _startPosX, _startPosY);
            }

            if (_numberDopGun == Enumeration.Three)
            {
                DrawDopGun_3(g, dopColor, _startPosX, _startPosY);
            }
        }

        public void DrawDopGun_1(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            Pen pen = new Pen(Color.Black);
            Brush mainColorGun = new SolidBrush(dopColor);
            g.DrawRectangle(pen, _startPosX - 20, _startPosY + 20, 95, 10);              //большое орудие
            g.FillRectangle(mainColorGun, _startPosX - 20, _startPosY + 20, 95, 10);    //большое орудие

            Pen penLine = new Pen(Color.Black, 6);
            g.DrawLine(penLine, _startPosX - 30, _startPosY + 35,  _startPosX - 20, _startPosY + 25);
            g.DrawLine(penLine, _startPosX -20, _startPosY + 20, _startPosX - 30, _startPosY + 10);
            g.DrawLine(penLine, _startPosX - 28, _startPosY + 10, _startPosX - 28, _startPosY + 35);
        }

        public void DrawDopGun_2(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            DrawDopGun_1(g, dopColor, _startPosX, _startPosY);
            Pen penSmallGun = new Pen(Color.Black, 5);
            g.DrawLine(penSmallGun, _startPosX + 165, _startPosY + 15, _startPosX + 190, _startPosY + 15);// малое орудие в бр.машине №1


            Pen penLine = new Pen(Color.Black, 2);
            g.DrawLine(penLine, _startPosX + 200, _startPosY + 10, _startPosX + 200, _startPosY + 25);
            g.DrawLine(penLine, _startPosX + 190, _startPosY + 15, _startPosX +200, _startPosY +25);
            g.DrawLine(penLine, _startPosX +190, _startPosY + 15, _startPosX +200, _startPosY + 10);
        }

        public void DrawDopGun_3(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            DrawDopGun_2(g, dopColor, _startPosX, _startPosY);
            Pen penGun = new Pen(Color.Black, 3);
            g.DrawLine(penGun, _startPosX + 225, _startPosY + 35, _startPosX + 280, _startPosY + 35);// малое орудие в бр.машине №2 горизонтальная часть
            g.DrawLine(penGun, _startPosX + 225, _startPosY + 35, _startPosX + 225, _startPosY + 50);// малое орудие в бр.машине №2 вертикальная часть


            Pen penLine = new Pen(Color.Black, 2);
            g.DrawLine(penLine, _startPosX + 295, _startPosY + 25, _startPosX + 295, _startPosY + 45);
            g.DrawLine(penLine, _startPosX + 280, _startPosY + 35, _startPosX + 295, _startPosY + 45);
            g.DrawLine(penLine, _startPosX + 280, _startPosY + 35, _startPosX + 295, _startPosY + 25);
        }
    }
}

