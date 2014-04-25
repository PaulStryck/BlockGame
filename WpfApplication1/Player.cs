using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Shapes;
using System.Windows.Media;

namespace BlockGame
{
    public class Player
    {
        private String name;
        private Rectangle recPlayer = new Rectangle();
        private int[] position = new int[2]; 

        public void setName(string name)
        {
            this.name = name;
        }

        public void setRectangle(Brush col)
        {
            this.recPlayer.Fill = col;
        }

        public Rectangle getRectangle()
        {
            return this.recPlayer;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + this.name.ToString();
        }

        public void moveDown()
        {
            if(this.position[0] != 5)
                this.position[0] += 1;
        }

        public void moveUp()
        {
            if (this.position[0] != 0)
                this.position[0] -= 1;
        }

        public void moveLeft()
        {
            if (this.position[1] != 0)              
                this.position[1] -= 1;
        }

        public void moveRight()
        {
            if (this.position[1] != 5)
                this.position[1] += 1;
        }

        public int[] getPositon()
        {
            return this.position;
        }
    }
}
