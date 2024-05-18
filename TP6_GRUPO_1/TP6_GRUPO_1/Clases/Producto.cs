using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_GRUPO_1
{
    public class Producto
    {
        private int _idCategoria;
        private int _unidadesExistencia;
        private int _unidadesPedidos;
        private int _nivelNuevoPedido;
        private bool _suspendido;

        /// GET Y SET
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public string cantidadUnidad { get; set; }
        public decimal precioUnitario { get; set; }
        public int idProveedor { get; set; }

        ///CONSTRUCTORES

        public Producto() { } //VACIO
        public Producto(int idProd, string nombreProd, string cantidadUni, decimal precioUni)
        {
            idProducto = idProd;
            nombreProducto = nombreProd;
            cantidadUnidad = cantidadUni;
            precioUnitario = precioUni;
        }

        public Producto(int idProd, string nombreProd, int idProv, decimal precioUni)
        {
            idProducto = idProd;
            nombreProducto = nombreProd;
            idProveedor = idProv;
            precioUnitario = precioUni;
        }

       
    }
}