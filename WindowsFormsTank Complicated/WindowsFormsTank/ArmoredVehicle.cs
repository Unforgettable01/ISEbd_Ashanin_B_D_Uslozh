﻿using System.Drawing;
namespace WindowsFormsTank
{
    public class ArmoredVehicle : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки танка
        /// </summary>
        protected readonly int armoredVehicleWidth = 290;
        /// <summary>
        /// Высота отрисовки танка
        /// </summary>
        protected readonly int armoredVehicleHeight = 200;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public ArmoredVehicle(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструкторс изменением размеров брон.машины
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес брон.машины</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="carWidth">Ширина отрисовки брон.машины</param>
        /// <param name="carHeight">Высота отрисовки брон.машины</param>
        protected ArmoredVehicle(int maxSpeed, float weight, Color mainColor, int carWidth, int
       carHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.armoredVehicleWidth = carWidth;
            this.armoredVehicleHeight = carHeight;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                    case Direction.Right:
                    if (_startPosX + step < _pictureWidth - armoredVehicleWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                    case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                    case Direction.Down:
                    if (_startPosY + step < _pictureHeight - armoredVehicleHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            // теперь отрисуем основной кузов танка          
            ///сам танк
            ///////////////////////////////////////////////////////////////////////////////////
            Brush mainColor = new SolidBrush(MainColor);
            g.DrawRectangle(pen, _startPosX + 75, _startPosY + 10, 90, 40);   //тело башни
            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 50, 250, 90);  // основное тело танка
            g.FillRectangle(mainColor, _startPosX + 75, _startPosY + 10, 90, 40);   //тело башни
            g.FillRectangle(mainColor, _startPosX + 10, _startPosY + 50, 250, 90);  // основное тело танка
            ///////////////////////////отрисовка колес
            Brush brGray = new SolidBrush(Color.Gray);
            g.DrawEllipse(pen, _startPosX + 30, _startPosY + 140, 50, 50); // колесо от бр.машины №1  в танке №2           
            g.DrawEllipse(pen, _startPosX + 180, _startPosY + 140, 50, 50); // колесо от бр.машины №2  в танке №5
            g.FillEllipse(brGray, _startPosX + 30, _startPosY + 140, 50, 50); //  колесо от бр.машины №1  в танке №2           
            g.FillEllipse(brGray, _startPosX + 180, _startPosY + 140, 50, 50); //  колесо от бр.машины №2  в танке №5        
        }
    }
}
