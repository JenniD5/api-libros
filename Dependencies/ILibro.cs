using System.Collections.Generic;
using libros_api.Modules;
using Microsoft.AspNetCore.Mvc;

namespace libros_api.Dependencies
{
    public interface ILibro
    {
        List<Libros> GetLibrosList();

        Libros GetLibros(int id);
    }
}