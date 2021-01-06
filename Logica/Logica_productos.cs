using System;
using System.Collections.Generic;
using System.Web;
using Acceso_Datos;
using Entidades;

namespace Logica
{
    public class Logica_productos
    {

        productos productosAD = new productos();

        public int InsertarProducto(Productos pro)
        {
            int respuesto = 0;
            try
            {
                respuesto = productosAD.InsertarProducto(pro);
            }
            catch (Exception)
            {

                throw;
            }
            return respuesto;
        }
        public int ModificarProducto(Productos pro)
        {
            int respuesto = 0;
            try
            {
                respuesto = productosAD.Modificar(pro);
            }
            catch (Exception)
            {

                throw;
            }
            return respuesto;
        }

        public int ElimanrProducto(Productos pro)
        {
            int respuesto = 0;
            try
            {
                respuesto = productosAD.deleteProducto(pro);
            }
            catch (Exception)
            {

                throw;
            }
            return respuesto;
        }
    }
}