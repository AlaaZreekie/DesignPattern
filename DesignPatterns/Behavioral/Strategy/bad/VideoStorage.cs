using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Strategy.bad
{
    public class VideoStorage
    {
        private Comressors _comressors;
        private Overlays _overlays;

        public VideoStorage(Comressors comressors, Overlays overlays = Overlays.NONE)
        {
            _comressors = comressors;
            _overlays = overlays;
        }

        public void SetCompresser(Comressors comressors)
        {
            _comressors = comressors;
        }

        public void SetOverlyas(Overlays overlays)
        {
            _overlays = overlays;
        }

        public void Store(string fileName)
        {
            //Compressing 
            if (_comressors == Comressors.MOV)
                Console.WriteLine("Using mov");
            else if (_comressors == Comressors.WEB4)
                Console.WriteLine("Ising WEB4");
            else if (_comressors == Comressors.MP4)
                Console.WriteLine("Using MP4");

            //OverLays
            if (_overlays == Overlays.NONE)
                Console.WriteLine("Using NONE");
            else if (_overlays == Overlays.Blur)
                Console.WriteLine("Ising Blur");
            else if (_overlays == Overlays.BlackAndWhite)
                Console.WriteLine("Using BlackAndWhite");

            Console.WriteLine("Storing into file: " + fileName);
        }

    }
}
