using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RbxGifGen
{
    public class GifImage
    {
        ListDictionary GifCache = new ListDictionary();
        private Image gifImage;
        private FrameDimension dimension;
        public int frameCount = 0;
        public int currentFrame = -1;
        private bool reverse;
        private int step = 1;

        public GifImage(string path)
        {
            gifImage = Image.FromFile(path); //initialize
            dimension = new FrameDimension(gifImage.FrameDimensionsList[0]); //gets the GUID
            frameCount = gifImage.GetFrameCount(dimension); //total frames in the animation
        }

        public bool ReverseAtEnd //whether the gif should play backwards when it reaches the end
        {
            get { return reverse; }
            set { reverse = value; }
        }

        public Image GetNextFrame()
        {

            currentFrame += step;

            //if the animation reaches a boundary...
            if (currentFrame >= frameCount || currentFrame < 1)
            {
                if (reverse)
                {
                    step *= -1; //...reverse the count
                    currentFrame += step; //apply it
                }
                else
                    currentFrame = 0; //...or start over
            }
            return GetFrame(currentFrame);
        }

        public Image GetFrame(int index)
        {
            if (GifCache[index] == null)
            {
                gifImage.SelectActiveFrame(dimension, index); //find the frame
                Image frame = (Image)gifImage.Clone();
                GifCache.Add(index, frame);
                return frame; //return a copy of it
            }
            else
            {
                return (Image)GifCache[index];
            }
        }
    }
}
