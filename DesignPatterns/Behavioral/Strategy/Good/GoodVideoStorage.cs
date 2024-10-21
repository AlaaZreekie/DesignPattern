using DesignPattern.DesignPatterns.Behavioral.Strategy.bad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Strategy.Good
{
    public class GoodVideoStorage
    {
        private ICompressor _compressors;
        private IOverlay _overlay;

        public GoodVideoStorage(ICompressor compressors, IOverlay overlay)
        {
            _compressors = compressors;
            _overlay = overlay;
        }

        public void SetCompresser(ICompressor comressors)
        {
            _compressors = comressors;
        }

        public void SetOverlyas(IOverlay overlays)
        {
            _overlay = overlays;
        }

        public void Store(string fileName)
        {
            /*//Compressing 
            if (_compressors == Comressors.MOV)
                Console.WriteLine("Using mov");
            else if (_compressors == Comressors.WEB4)
                Console.WriteLine("Ising WEB4");
            else if (_compressors == Comressors.MP4)
                Console.WriteLine("Using MP4");

            //OverLays
            if (_overlays == Overlays.NONE)
                Console.WriteLine("Using NONE");
            else if (_overlays == Overlays.Blur)
                Console.WriteLine("Ising Blur");
            else if (_overlays == Overlays.BlackAndWhite)
                Console.WriteLine("Using BlackAndWhite");*/

            _compressors.Compress();
            _overlay.Apply();

            Console.WriteLine("Storing into file: " + fileName);
        }
    }
}
