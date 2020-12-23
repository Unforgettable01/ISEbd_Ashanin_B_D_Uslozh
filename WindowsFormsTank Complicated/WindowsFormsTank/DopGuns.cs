
//using System.Drawing;

//namespace WindowsFormsTank
//{
//    class DopGuns: IDopGun
//    {
//        //закрытое поле
//        private  Enumeration _numberDopGun;

//        public int SetNumberDopGun
//        {
//            set
//            {
//                switch (value)
//                {
//                    case 1:
//                        _numberDopGun = Enumeration.One;
//                        break;
//                    case 2:
//                        _numberDopGun = Enumeration.Two;
//                        break;
//                    case 3:
//                        _numberDopGun = Enumeration.Three;
//                        break;
//                }
//            }
//        }

      
//        public void DrawDopGun(Graphics g, Color dopColor, float _startPosX, float _startPosY)
//        {
            
            
//            Pen pen = new Pen(Color.Black);


//            if (_numberDopGun == Enumeration.One)
//            {
//                Brush mainColorGun = new SolidBrush(dopColor);
//                g.DrawRectangle(pen, _startPosX - 20, _startPosY + 20, 95, 10);              //большое орудие
//                g.FillRectangle(mainColorGun, _startPosX - 20, _startPosY + 20, 95, 10);    //большое орудие
//                return;
//            }

//            if (_numberDopGun == Enumeration.Two)
//            {
//                Pen penSmallGun = new Pen(Color.Black, 5);
//                g.DrawLine(penSmallGun, _startPosX + 165, _startPosY + 15, _startPosX + 190, _startPosY + 15);// малое орудие в бр.машине №1
//            }

//            if (_numberDopGun == Enumeration.Three)
//            {
//                Pen penGun = new Pen(Color.Black, 3);
//                g.DrawLine(penGun, _startPosX + 225, _startPosY + 35, _startPosX + 280, _startPosY + 35);// малое орудие в бр.машине №2 горизонтальная часть
//                g.DrawLine(penGun, _startPosX + 225, _startPosY + 35, _startPosX + 225, _startPosY + 50);// малое орудие в бр.машине №2 вертикальная часть
//            }

           
//        }
//    }

//}
