using System;

namespace Assets.Scripts.Exceptions
{
    class ObjectOutOfScreenException : ApplicationException
    {
        public ObjectOutOfScreenException(string message, bool minX, bool maxX, bool minY, bool maxY)
            : base(message)
        {
            this.IsMinX = minX;
            this.IsMaxX = maxX;
            this.IsMinY = minY;
            this.IsMaxY = maxY;
        }

        public bool IsMinX { get; set; }
        public bool IsMaxX { get; set; }
        public bool IsMinY { get; set; }
        public bool IsMaxY { get; set; }
    }
}
