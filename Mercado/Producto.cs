using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    class Producto
    {
        public string _code { get;  }
        public string _nombre { get; set; }
        public string _inf { get; set; }
        public int _cantidad;
        public int _costo;

        public Producto(string code, string nombre, string info, int cantidad, int costo)
        {
            _code = code;
            _nombre = nombre;
            _inf = info;
            _cantidad = cantidad;
            _costo = costo;
        }

        public override string ToString()
        {
            return _code +" " + _nombre + " " + _inf + " " + _cantidad + " " + _costo;
        }
    }
}
