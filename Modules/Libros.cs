using System;

namespace libros_api.Modules
{
    public class Libros
    {   Int64 id;
        string titulo;
        

        public Libros(){}

        public Libros(Int64 id ,string titulo)
        {
            this.id=id;
            this.titulo=titulo;
            
            
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public Int64 Id{get=> id; set=> id=value;}
    }
}