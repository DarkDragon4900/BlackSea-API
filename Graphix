public class Graphix
{
    Size _wSize;

    /// <summary>
    /// Initializes a Graphics component using a size.
    /// </summary>
    /// <param name="worldSize">The size of the world the bot is connected to.</param>
    public Graphix(Size worldSize)
    {
        _wSize = worldSize;
    }

    /// <summary>
    /// Initializes a Graphics component using two ints.
    /// </summary>
    /// <param name="worldWidth">The width of the world the bot is connected to.</param>
    /// <param name="worldHeight">The height of the world the bot is connected to.</param>
    public Graphix(int worldWidth, int worldHeight)
    {
        _wSize = new Size(worldWidth, worldHeight);
    }

    /// <summary>
    /// Draws a line of blocks through two points.
    /// </summary>
    /// <param name="pt1">The first point from which the line would start.</param>
    /// <param name="pt2">The second point at which the line ends.</param>
    /// <returns>Returns a list of points(coords) which resemble a line.</returns>
    public List<Point> DrawLine(Point pt1, Point pt2)
    {
        List<Point> pts = new List<Point>();
        Bitmap b = new Bitmap(_wSize.Width, _wSize.Height);
        Graphics G = Graphics.FromImage(b);
        G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(0, 0, 0))), pt1, pt2);
        for (int x = 0; x < _wSize.Width; x++)
            for (int y = 0; y < _wSize.Height; y++)
                if (b.GetPixel(x, y) == Color.FromArgb(0, 0, 0))
                    pts.Add(new Point(x, y));
        return pts;
    }

    /// <summary>
    /// Draws a rectangle (borders of a rectangle) in a specific point and size.
    /// </summary>
    /// <param name="location">The coords where the rectangle's top left corner would be.</param>
    /// <param name="size">The size of the rectangle.</param>
    /// <returns>Returns a list of points(coords) which resemble a rectangle.</returns>
    public List<Point> DrawRectangle(Point location, Size size)
    {
        List<Point> pts = new List<Point>();
        Bitmap b = new Bitmap(_wSize.Width, _wSize.Height);
        Graphics G = Graphics.FromImage(b);
        G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(0, 0, 0))), new Rectangle(location, size));
        for (int x = 0; x < _wSize.Width; x++)
            for (int y = 0; y < _wSize.Height; y++)
                if (b.GetPixel(x, y) == Color.FromArgb(0, 0, 0))
                    pts.Add(new Point(x, y));
        return pts;
    }

    /// <summary>
    /// Fills a rectangle in a specific point and size.
    /// </summary>
    /// <param name="location">The coords where the rectangle's top left corner would be.</param>
    /// <param name="size">The size of the rectangle.</param>
    /// <returns>Returns a list of points(coords) which resemble a filled rectangle.</returns>
    public List<Point> FillRectangle(Point location, Size size)
    {
        List<Point> pts = new List<Point>();
        Bitmap b = new Bitmap(_wSize.Width, _wSize.Height);
        Graphics G = Graphics.FromImage(b);
        G.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(location, size));
        for (int x = 0; x < _wSize.Width; x++)
            for (int y = 0; y < _wSize.Height; y++)
                if (b.GetPixel(x, y) == Color.FromArgb(0, 0, 0))
                    pts.Add(new Point(x, y));
        return pts;
    }

    /// <summary>
    /// Draws a circle with an imaginary rectangle forming it's borders.
    /// </summary>
    /// <param name="location">Specifies where the top left corner of the rectangle around the circle should be.</param>
    /// <param name="size">Specifies the width and height of the rectangle around the circle.</param>
    /// <returns></returns>
    public List<Point> DrawCircle(Point location, Size size)
    {
        List<Point> pts = new List<Point>();
        Bitmap b = new Bitmap(_wSize.Width, _wSize.Height);
        Graphics G = Graphics.FromImage(b);
        G.DrawEllipse(new Pen(new SolidBrush(Color.FromArgb(0, 0, 0))), new Rectangle(location, size));
        for (int x = 0; x < _wSize.Width; x++)
            for (int y = 0; y < _wSize.Height; y++)
                if (b.GetPixel(x, y) == Color.FromArgb(0, 0, 0))
                    pts.Add(new Point(x, y));
        return pts;
    }

    /// <summary>
    /// Fill a circle with an imaginary rectangle forming it's borders.
    /// </summary>
    /// <param name="location">Specifies where the top left corner of the rectangle around the circle should be.</param>
    /// <param name="size">Specifies the width and height of the rectangle around the circle.</param>
    /// <returns></returns>
    public List<Point> DrawCircle(Point location, Size size)
    {
        List<Point> pts = new List<Point>();
        Bitmap b = new Bitmap(_wSize.Width, _wSize.Height);
        Graphics G = Graphics.FromImage(b);
        G.FillEllipse(new SolidBrush(Color.FromArgb(0, 0, 0)), new Rectangle(location, size));
        for (int x = 0; x < _wSize.Width; x++)
            for (int y = 0; y < _wSize.Height; y++)
                if (b.GetPixel(x, y) == Color.FromArgb(0, 0, 0))
                    pts.Add(new Point(x, y));
        return pts;
    }
}
