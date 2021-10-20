using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"Beer.jpg");
            
           

           IFilter Filtro1 = new FilterGreyscale();
           IFilter Filtro2 = new FilterNegative();
           PipeNull pipe1 = new PipeNull();
           PipeSerial pipe2 = new PipeSerial(Filtro1,pipe1);
           PipeSerial pipe3 = new PipeSerial(Filtro2,pipe2);


           PictureProvider provider1 = new PictureProvider();
           provider.SavePicture(picture, @"Beer.jpg");



        }
    }
}
