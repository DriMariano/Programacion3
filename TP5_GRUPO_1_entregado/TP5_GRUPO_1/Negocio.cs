using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;

namespace TP5_GRUPO_1
{
    public class Negocio
    {
        //creo una instancia de la clase Acceso a Datos
        AccesoDatos datos=new AccesoDatos();
        public DataTable ObtenerProvincias()
        {
            //envio consulta y tipo de comando al metodo creado en la clase Acceso a Datos
            datos.configurarComando("SELECT * FROM Provincia", CommandType.Text);
            string nombreTabla = "Provincia"; 
            return datos.obtenerTablas(nombreTabla); 
                      
        }

        public int agregarSucursal(string nombre, string descripcion,int provincia, string direccion)
        {
            //envio consulta y tipo de comando al metodo creado en la clase Acceso a Datos
            datos.configurarComando("insert into Sucursal (NombreSucursal,DescripcionSucursal,Id_ProvinciaSucursal,DireccionSucursal) values (@nombresucursal,@descripcion,@idprovincia,@direccion)", CommandType.Text);
            
            //envio parametros con este metodo para terminar de armar la consulta
            datos.agregarParametro("@nombresucursal",nombre) ;
            datos.agregarParametro("@descripcion", descripcion) ;
            datos.agregarParametro("@idprovincia", provincia);
            datos.agregarParametro("@direccion", direccion);
            /*llamo al metodo que ejecuta la consulta en la base de datos y 
             lo igualo a una varaible entera que representa la cantidad de filas afectadas por la consulta*/
            int filas=datos.ejecutarConsulta();
            return filas;
        }


        //Metodo que devuelve una tabla con los datos de las sucursales
        public DataTable listarSucursales()
        {
            //envio consulta y tipo de comando al metodo creado en la clase Acceso a Datos
            datos.configurarComando("SELECT Id_Sucursal AS ID, NombreSucursal AS NOMBRE, DescripcionSucursal, " +
                                           "DescripcionProvincia AS PROVINCIA, DireccionSucursal AS DIRECCIÓN " +
                                    "FROM Sucursal " +
                                    "INNER JOIN Provincia ON Id_Provincia=Id_ProvinciaSucursal", CommandType.Text);
            string nombreTabla = "Sucursales";
            return datos.obtenerTablas(nombreTabla);  // metodo que devuelve la tabla asignada como parametro
        }
        //Metodo que recibe el id de sucursal y devuelve una tabla con los datos de esta. 
        public DataTable filtrarSucursales(string id)
        
        {
            //envio consulta y tipo de comando al metodo creado en la clase Acceso a Datos
            datos.configurarComando("SELECT Id_Sucursal AS ID, NombreSucursal AS NOMBRE, DescripcionSucursal, " +
                                            "DescripcionProvincia AS PROVINCIA, DireccionSucursal AS DIRECCIÓN " +
                                    "FROM Sucursal " +
                                    "INNER JOIN Provincia ON Id_Provincia = Id_ProvinciaSucursal " +
                                    "WHERE Id_Sucursal = @idsucursal", CommandType.Text);
            datos.agregarParametro("@idsucursal", id); // agrego el id como parametro de la consulta
            string nombreTabla = "Sucursales";
            return datos.obtenerTablas(nombreTabla);// metodo que devuelve la tabla asignada como parametro
        }

        public int eliminarSucursal(string id)
        {
            datos.configurarComando("spEliminarSucursal", CommandType.StoredProcedure);
            datos.agregarParametro("@idsucursal", id);
            int filas=datos.ejecutarConsulta();
            return filas;
        }
    }
}