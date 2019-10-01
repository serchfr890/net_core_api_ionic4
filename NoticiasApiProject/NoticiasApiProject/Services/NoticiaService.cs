using NoticiasApiProject.DbContextFiles;
using NoticiasApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticiasApiProject.Services
{
    public class NoticiaService
    {
        private readonly NoticiasDbContext _noticiasDbContext;
        public NoticiaService(NoticiasDbContext noticiasDbContext)
        {
            _noticiasDbContext = noticiasDbContext;
        }

        public Boolean AgregarNoticia(Noticia _noticia)
        {
            try
            {
                _noticiasDbContext.Noticia.Add(_noticia);
                _noticiasDbContext.SaveChanges();
                return true;
            } catch (Exception error)
            {
                return false;
            }
        }
    }
}
