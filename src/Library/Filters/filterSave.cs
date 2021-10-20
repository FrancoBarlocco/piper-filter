using System;
using System.Drawing;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que recibe una imagen y retorna su negativo.
    /// </remarks>
    public class SaveFilter : IFilter
    {

        public IPicture Filter(IPicture imagen)
        {
            
            PictureProvider provider0 = new PictureProvider();
            provider0.SavePicture(imagen, @"prueba.jpg");  
            return imagen;        
        }

    }
}