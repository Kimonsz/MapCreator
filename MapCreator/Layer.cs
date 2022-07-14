using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MapCreator
{
    class Layer
    {
        public int zValue; //information about Z- axis of layer

        public Layer(int zVal)
        {
            this.zValue = zVal;

        }
    }
}
