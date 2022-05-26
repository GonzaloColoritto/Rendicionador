using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Entidades
{
    public class Item
    {

        /*
         Fijarse que es probable que los campos que utilice en la rendicion podrian o no ser estaticos.
         Por el momento quedan para que el lo escriba manualmente, pero esto podria cambiar.
         */
        string detalle;
        float importe;

        public Item(string detalle, float importe)
        {
            this.Detalle = detalle;
            this.Importe = importe;
        }

        public string Detalle { get => detalle; set => detalle = value; }
        public float Importe { get => importe; set => importe = value; }




    }
}
