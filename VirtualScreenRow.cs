
namespace Tilfeldige_Firkanter
{
    public class VirtualScreenRow
    {
        private VirtualScreenCell[] _cells;
        private int _width;
        private int _startX;

        public VirtualScreenRow(int width, int startX)
        {
            _width = width;
            _startX = startX;
            _cells = new VirtualScreenCell[width];

            for (int i = 0; i < width; i++)
            {
                _cells[i] = new VirtualScreenCell();
            }
            
        }

        public void AddBoxTopRow(int boxX, int boxWidth)
        {

        }
        public void AddBoxBottomRow(int boxX, int boxWidth)
        public void AddBoxMiddleRow(int boxX, int boxWidth)



        public void Show() { }
    }
}
