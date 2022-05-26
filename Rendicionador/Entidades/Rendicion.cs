using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Entidades
{
    public  class Rendicion
    {
         List<Item> items;
         DateTime fecha;
         int numero;
         int refFac;

        public Rendicion()
        {
            this.Items = new List<Item>();
        }

        public Rendicion(DateTime date, int nroren, int reffac):this()
        {
            this.fecha = date;
            this.numero = nroren;
            this.refFac = reffac;
        }
        public Rendicion(List<Item> items, DateTime fecha, int numero, int refFac)
        {
            Items = items;
            Fecha = fecha;
            this.numero = numero;
            this.refFac = refFac;
        }

        public List<Item> Items
        {
            get
            {
                return this.items;
            }
            set
            {
                this.items = value;
            }
        }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Numero { get => numero; set => numero = value; }
        public int RefFac { get => refFac; set => refFac = value; }

        public double CalcularTotal()
         {
            double totalProvisorio = 0;
            
            foreach (Item unit in Items)
            {
                totalProvisorio += unit.Importe;    
            }

            return totalProvisorio;
         }


    }
}
