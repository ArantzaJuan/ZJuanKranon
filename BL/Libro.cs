using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Libro
    {
       public static ML.Result AddLibro(ML.Libro libro)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ZjuanKranonContext context = new DL.ZjuanKranonContext())
                {
                    var addLibro = context.Database.ExecuteSqlRaw($"LibroAdd'{libro.Autor}','{libro.TItulo}','{libro.AñoPublicacion}','{libro.Editorial}'");
                    if (addLibro>0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch(Exception e)
            {
                result.Correct = false;
                result.ErrorMenssage = e.Message;
                
            }
            return result;
        }
       public static ML.Result GetAutor(string Autor)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ZjuanKranonContext context = new DL.ZjuanKranonContext())
                {
                    var getAutor= context.Libros.FromSqlRaw($"LibrosporAutor'{Autor}'").AsEnumerable().FirstOrDefault();
                    result.Object = new List<object>();
                    if (getAutor != null)
                    {

                        ML.Libro libro = new ML.Libro();
                        libro.IdLibre = getAutor.IdLibre;
                        libro.Autor = getAutor.Autor;
                        libro.TItulo = getAutor.Titulo;
                        libro.AñoPublicacion = getAutor.AñoPublicacion;
                        libro.Editorial = getAutor.Editorial;
                        result.Object= libro;
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch (Exception e)
            {
                result.Correct= false;
                result.ErrorMenssage=e.Message;
            }
            return result;
        }
       public static ML.Result GetTitulo(string TItulo)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ZjuanKranonContext context = new DL.ZjuanKranonContext())
                {
                    var getAutor = context.Libros.FromSqlRaw($"LibrosporTitulo'{TItulo}'").AsEnumerable().FirstOrDefault();
                    result.Object = new List<object>();
                    if (getAutor != null)
                    {

                        ML.Libro libro = new ML.Libro();
                        libro.IdLibre = getAutor.IdLibre;
                        libro.Autor = getAutor.Autor;
                        libro.TItulo = getAutor.Titulo;
                        libro.AñoPublicacion = getAutor.AñoPublicacion;
                        libro.Editorial = getAutor.Editorial;
                        result.Object = libro;
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMenssage = e.Message;
            }
            return result;
        }
       public static ML.Result GetAutorAño(string Autor, string Año)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ZjuanKranonContext context = new DL.ZjuanKranonContext())
                {
                    var getAutor = context.Libros.FromSqlRaw($"LibrosporAutoryAño'{Autor}','{Año}").AsEnumerable().FirstOrDefault();
                    result.Object = new List<object>();
                    if (getAutor != null)
                    {

                        ML.Libro libro = new ML.Libro();
                        libro.IdLibre = getAutor.IdLibre;
                        libro.Autor = getAutor.Autor;
                        libro.TItulo = getAutor.Titulo;
                        libro.AñoPublicacion = getAutor.AñoPublicacion;
                        libro.Editorial = getAutor.Editorial;
                        result.Object = libro;
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMenssage = e.Message;
            }
            return result;
        }
        public static ML.Result GetEditorial(string Editorial)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ZjuanKranonContext context = new DL.ZjuanKranonContext())
                {
                    var getAutor = context.Libros.FromSqlRaw($"LibrosporEditorial'{Editorial}'").AsEnumerable().FirstOrDefault();
                    result.Object = new List<object>();
                    if (getAutor != null)
                    {

                        ML.Libro libro = new ML.Libro();
                        libro.IdLibre = getAutor.IdLibre;
                        libro.Autor = getAutor.Autor;
                        libro.TItulo = getAutor.Titulo;
                        libro.AñoPublicacion = getAutor.AñoPublicacion;
                        libro.Editorial = getAutor.Editorial;
                        result.Object = libro;
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMenssage = e.Message;
            }
            return result;
        }

        public static ML.Result DeleteLibroAutor (string Autor)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ZjuanKranonContext context = new DL.ZjuanKranonContext())
                {
                    var addLibro = context.Database.ExecuteSqlRaw($"LibroDeleteAutor '{Autor}");
                    if (addLibro > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMenssage = e.Message;

            }
            return result;
        }
        public static ML.Result DeleteLibroEditorial(string Editorial)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ZjuanKranonContext context = new DL.ZjuanKranonContext())
                {
                    var addLibro = context.Database.ExecuteSqlRaw($"LibroDeleteEditorial '{Editorial}");
                    if (addLibro > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMenssage = e.Message;

            }
            return result;
        }
    }
}
