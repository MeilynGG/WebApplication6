using System;
using System.Collections.Generic;
using System.Web;

namespace Entidades
{
    public class Categoria
    {
        public string tipo;
        public int id_categoria;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int IdCategoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }

  
    }
}