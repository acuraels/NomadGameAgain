using System.Drawing;
using System.Windows.Forms;

namespace NomadGameAgain.GameObjects
{
    public class Obstacle : Control
    {
        public Obstacle()
        {
            // Устанавливаем размеры и цвет препятствия
            this.Size = new Size(50, 50); // Установи размеры в соответствии с требованиями игры
            this.BackColor = Color.Gray; // Установи цвет препятствия на свой вкус
        }
    }
}
