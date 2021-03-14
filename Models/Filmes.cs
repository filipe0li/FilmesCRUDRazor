using System;

namespace FilmesCRUDRazor.Models
{
    internal class Filme
    {
        public int FilmeId { get; set; }
        public string Titulo { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Genero { get; set; }
        public decimal Preco { get; set; }
    }
}