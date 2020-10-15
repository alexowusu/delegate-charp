using System;

namespace DelegateTut
{
    class PhotoProcessor
    {


        //public delegate void PhotoFilterHandler(Photo photo);

        //public void Process(PhotoFilterHandler filterHandler)
        public void Process(Action<Photo> filterHandler)
        {
            filterHandler(new Photo()); 

            //var filters = new PhotoFilters();

            //filters.ApplyBrightness(new Photo());
            //filters.ApplyContrast(new Photo());
            //filters.ApplyResize(new Photo());

        }
    }
}
