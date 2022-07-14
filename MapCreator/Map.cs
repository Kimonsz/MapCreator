using System.Drawing;

namespace MapCreator
{
    class Map
    {
        private int xValue;     //number of squares in x axis
        private int yValue;     //number of squares in y axis
        private int xPxValue;   //number of pixels in x axis
        private int yPxValue;   //number of Pixels in y axis
        private int squareSize;
        private Bitmap mainBitmap;
        private int gridSize;

        public Map(int xVal,int yVal,int gridSize,int sqrSize)
        {
            xValue = xVal;
            yValue = yVal;
            squareSize = sqrSize;
            this.gridSize = gridSize;
            xPxValue = xValue * squareSize + gridSize * xValue - 1;
            yPxValue = yValue * squareSize + gridSize * yValue - 1;

            mainBitmap = new Bitmap(xPxValue,yPxValue);
        }
    }
}