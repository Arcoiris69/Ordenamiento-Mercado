using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    class Inventario
    {
        private Producto[] _inventario = new Producto[15];
        string output = "";

        public void AddProduct(Producto product, int position)
        {
            if (position >= _inventario.Length)
            {
                _inventario[14] = product;
            }
            else
            {
                for (int i = _inventario.Length - 1; i > position - 1; i--)
                {
                    _inventario[i] = _inventario[i - 1];
                }
                _inventario[position] = product;

            }

        }
        public Producto SearchProduct(string code)
        {
            for (int i = 0; i < 15; i++)
                if (_inventario[i] != null)
                    if (_inventario[i]._code == code)
                        return _inventario[i];
            return null;
        }
        public void DeleteProduct(int position)
        {
            for (int i = position; i < _inventario.Length ; i++)
            {

                _inventario[i] = _inventario[i + 1];
                
            }
            _inventario[_inventario.Length - 1] = null;

        }
        public string ListAllProducts()
        {
            
            for (int i = 0; i < _inventario.Length; i++)
            {
                output += _inventario[i];
            }
                return output;   
        }
        
        
    }
}
