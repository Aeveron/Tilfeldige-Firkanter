﻿
namespace Tilfeldige_Firkanter
{
    class VirtualScreenCell
    {
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }

        public char GetCharacter()
        {          
           
            if (!Up && !Right && Down && Left) return '┌';
            if (!Up && !Down && Left && Right) return '─';
            if (!Up && Down && !Left && Right) return '┐';
            if (Up && !Down && !Left && Right) return '└';
            if (Up && !Down && Left && !Right) return '┘';
            if (Up && Down && !Left && !Right) return '│';
            if (Up && Down && Left && Right)   return '┼';
            if (!Up && Down && Left && Right) return '┬';
            if (Up && Down && Left && !Right) return '┤';
            if (Up && Down && !Left && Right) return '├';
            if (Up && !Down && Left && Right) return '┴';
            if (!Up && Down && Left && Right) return '┬';

            return ' ';
        }

        public void AddHorizontal()
        {
            Right = Left = true;
        }

        public void AddVertical()
        {
            Up = Down = true;
        }

        public void AddLowerLeftCorner()
        {
            Up = Right = true;
        }

        public void AddUpperLeftCorner()
        {
            Down = Right = true;
        }

        public void AddUpperRightCorner()
        {
            Down = Left = true;
        }

        public void AddLowerRightCorner()
        {
            Up = Left = true;
        }
    }
}
