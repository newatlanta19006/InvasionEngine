using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvasionEngine.Core.UI.Controls
{
    public abstract class UIControlBase
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
