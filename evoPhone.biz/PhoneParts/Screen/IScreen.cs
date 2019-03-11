namespace evoPhone.biz {
    interface IScreen {
        double ImageSize { get; }
        int ColorDepth { get; }
        int PixelsX { get; }
        int PixelsY { get; }
    }
}