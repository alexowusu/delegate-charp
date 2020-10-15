using System;

namespace DelegateTut
{
    class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Applying brightness...");
        }
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Applying contrasting...");
        }
        public void ApplySaturation(Photo photo)
        {
            Console.WriteLine("Applying saturation...");
        }

        public void ApplyResize(Photo photo)
        {
            Console.WriteLine("Applying resizing...");
        }
    }
}
