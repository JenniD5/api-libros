using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using libros_api.Modules;
using libros_api.Dependencies;
using System.Data.SqlClient;  


namespace libros_api.Controllers
{
    [Route("sagas/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class LibrosController : ILibro
    {
        List<Libros> librosList => new List<Libros>
        {
            new Libros
            {
                Titulo = "Homero",
                
            },
        };



 //crear usuario en sql express y contraseña, con los detalles de la sig linea 
      /*string de coneccion */  
      string connectionString=@"data source=LAPTOP-ENL6O117\SQLEXPRESS; initial catalog=db-libros; user id=2sim; password=1234";
          


    

        [HttpGet("{id}")]
        public Libros GetLibros(int id)
        {
            return librosList[id];
        }

        [HttpGet]

        public List<Libros> GetLibrosList ()
        {
            List<Libros> libross=new List<Libros>();
            SqlConnection conn=new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select*from tbl_libros1", conn);
            conn.Open();
            SqlDataReader reader= cmd.ExecuteReader();
            while (reader.Read())
            {
             Libros libro = new Libros
             {
               Id= reader.GetInt64(reader.GetOrdinal("id")),
               Titulo =reader.GetString(reader.GetOrdinal("titulo")),
               
             };
             libross.Add(libro);
            }
           
            conn.Close();
            return libross;

        }
    }
}







