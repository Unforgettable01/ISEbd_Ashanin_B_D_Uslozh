using System.Drawing;

namespace WindowsFormsTank
{
    class GunsThirdStyle : IDopGun
    {
        private Enumeration _numberDopGun;

        public int SetNumberDopGun { set => _numberDopGun = (Enumeration)value; }
        public Color DopColor { private set; get; }

        public GunsThirdStyle(int gun, Color dopColor)
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
            Pen penEllipse = new Pen(Color.Black, 1);
            g.DrawEllipse(penEllipse, _startPosX - 25, _startPosY + 20, 10, 10);
            Brush sbEllipse = new SolidBrush(Color.Black);
            g.FillEllipse(sbEllipse, _startPosX - 25, _startPosY + 20, 10, 10);
        }

        public void DrawDopGun_2(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            DrawDopGun_1(g, dopColor, _startPosX, _startPosY);
            Pen penSmallGun = new Pen(Color.Black, 5);
            g.DrawLine(penSmallGun, _startPosX + 165, _startPosY + 15, _startPosX + 190, _startPosY + 15);// малое орудие в бр.машине №1
            g.DrawLine(penSmallGun, _startPosX + 165, _startPosY + 20, _startPosX + 190, _startPosY + 20);
            Pen pen = new Pen(Color.White, 2);
            g.DrawLine(pen, _startPosX + 165, _startPosY + 17, _startPosX + 190, _startPosY + 17);

        }

        public void DrawDopGun_3(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            DrawDopGun_2(g, dopColor, _startPosX, _startPosY);
            Pen penGun = new Pen(Color.Black, 3);
            g.DrawLine(penGun, _startPosX + 225, _startPosY + 35, _startPosX + 280, _startPosY + 35);// малое орудие в бр.машине №2 горизонтальная часть
            g.DrawLine(penGun, _startPosX + 225, _startPosY + 35, _startPosX + 225, _startPosY + 50);// малое орудие в бр.машине №2 вертикальная часть
            g.DrawLine(penGun, _startPosX + 245, _startPosY + 35, _startPosX + 245, _startPosY + 50);
            g.DrawLine(penGun, _startPosX + 255, _startPosY + 35, _startPosX + 255, _startPosY + 50);
        }
    }
}