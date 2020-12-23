using System.Drawing;

namespace WindowsFormsTank
{
    public interface IDopGun
    {
        int SetNumberDopGun
        {
            set;
        }
        void DrawDopGun(Graphics g, Color dopColor, float _startPosX, float _startPosY); //метод для отриисовки дополнительного орудия

    }
}
