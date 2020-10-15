using System;

//  Knows how to call a method / a group of methods
//  Ponter to a method with Similar signature...A reference to a function 
//  Designs extensible and flexible applications (eg frameworks)
//  Alternatively, interfaces
//  When an events handling design pattern is used...event chaining...
//  +....invoked method needs no other properties / methods on the object implementing the method...ie. no dependency

namespace DelegateTut
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoProcessor photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilters();

            Action<Photo> filterHandlerDelegate = filters.ApplyBrightness;
            //PhotoProcessor.PhotoFilterHandler filterHandlerDelegate = filters.ApplyBrightness;
            filterHandlerDelegate += filters.ApplyContrast;
            filterHandlerDelegate += filters.ApplyResize;

            // xtension
            filterHandlerDelegate += CropPhoto;

            photoProcessor.Process(filterHandlerDelegate);
        }

        // not realeased with the framework
        static void CropPhoto(Photo photo)
        {
            Console.WriteLine("Applying cropping...");
        }
    }
}
