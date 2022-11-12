using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Biblioteca
    {
        private string nome;
        private string indirizzo;
        private string apertura;
        private string chiusura;
        private List<Libro> libri;

        public Biblioteca(string nome, string indirizzo, string apertura, string chiusura, List<Libro> libri)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.apertura = apertura;
            this.chiusura = chiusura;
            this.libri = libri;
        }

        public void addLibro(Libro libro)
        {
            libri.Add(libro);
        }

        public Libro ricercaPerTitolo(string titolo)
        {
            foreach (Libro libro in libri)
            {
                if (libro.getTitolo() == titolo)
                {
                    return libro;
                }
            }
            return null;
        }

        public List<Libro> ricercaPerAutore(string autore)
        {
            List<Libro> libriAutore = new List<Libro>();
            foreach (Libro libro in libri)
            {
                if (libro.getAutore() == autore)
                {
                    libriAutore.Add(libro);
                }
            }
            if (libriAutore.Count > 0) return libriAutore;
            return null;
        }

        public int numeroLibri()
        {
            return libri.Count;
        }
    }
}
