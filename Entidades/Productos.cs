using System;
using System.Collections.Generic;
using System.Web;

namespace Entidades
{
    public class Productos
    {
        public string descripcion;
        public int id_categoria;
        public int id_producto;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Id_Categoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }

        public int ID
        {
            get { return id_producto; }
            set { id_producto = value; }
        }
    }
}