﻿namespace Passagem.Models
{
    public class NewsViewModel
    {
        public Noticias Noticias { get; set; }
        public IEnumerable<Categorias> ListaCategoria { get; set; }
    }

    public class NewsIndexViewModel
    {
        public IEnumerable<Noticias> ListaNoticias { get; set; }
        public IEnumerable<Categorias> ListaCategoria { get; set; }
    }
}
