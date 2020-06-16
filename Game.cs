using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string keyPressed, out int x, out int y)
        {
            x = 0;
            y = 0;

            switch(keyPressed)
            {
                case "UpArrow":
                    y -= 1;
                    break;

                case "DownArrow":
                    y += 1;
                    break;

                case "LeftArrow":
                    x -= 1;
                    break;

                case "RightArrow":
                    x += 1;
                    break;

            }
        }

       public new static char UpdateCursor(string keyPressed)
        {

            char direction = 'o';

            switch(keyPressed)
            {
                case "UpArrow":
                    direction = '^';
                    break;

                case "DownArrow":
                    direction = 'v';
                    break;

                case "LeftArrow":
                    direction = '<';
                    break;

                case "RightArrow":
                    direction = ('>');
                    break;
            }

            return direction;
        }
        public new static int KeepInBounds(int coordinate, int maxValue)
        {
            

            if (coordinate > maxValue)
            {
                return 0;
            }
            else if (coordinate < 0)
            {
                return maxValue;
            }
            else
            {
                return coordinate;
            }
        }


        public new static bool DidScore(int charX, int charY, int fruitX, int fruitY)
        {
            if(charX == fruitX && charY == fruitY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
  }
}
