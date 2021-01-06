using Acceso_Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Web;

namespace Logica
{
    public class Logica_categorias
    {
        Accedo_Datos_Categorias categoriasAD = new Accedo_Datos_Categorias();

        public int InsertarCategoria(Categoria cate)
        {
            int respuesto = 0;
            try
            {
                respuesto = categoriasAD.Insertar(cate);
            }
            catch (Exception)
            {

                throw;
            }
            return respuesto ;
        }

        public int ModificarCategoria(Categoria cate)
        {
            int respuesto = 0;
            try
            {
                respuesto = categoriasAD.Modificar(cate);
            }
            catch (Exception)
            {

                throw;
            }
            return respuesto;
        }

        public int EliminarCategoria(Categoria cate)
        {
            int respuesto = 0;
            try
            {
                respuesto = categoriasAD.deleteCategoria(cate);
            }
            catch (Exception)
            {

                throw;
            }
            return respuesto;
        }
    }

    
}