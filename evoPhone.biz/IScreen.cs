using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {
    interface IScreen {
        double ImageSize { get; set; }

        int ColorDepth { get; set; }

        int PixelsX { get; set; }

        int PixelsY { get; set; }
    }
}
