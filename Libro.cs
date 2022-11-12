using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Libro
    {
        private string autore;
        private string titolo;
        private int annoPubblicazione;
        private string editore;
        private int nPagine;

        public void setAutore(string autore)
        {
            this.autore = autore;
        }

        public string getAutore()
        {
            return autore;
        }

        public void setTitolo(string titolo)
        {
            this.titolo = titolo;
        }

        public string getTitolo()
        {
            return titolo;
        }

        public void setAnnoPubblicazione(int anno)
        {
            annoPubblicazione = anno;
        }

        public int getAnnoPubblicazione()
        {
            return annoPubblicazione;
        }

        public void setEditore(string editore)
        {
            this.editore = editore;
        }

        public string getEditore()
        {
            return editore;
        }

        public void setPagine(int pagine)
        {
            this.nPagine = pagine;
        }

        public int getPagine()
        {
            return nPagine;
        }

        public string toString()
        {
            return $"Autore: {autore}\nTitolo: {titolo}\nAnno: {annoPubblicazione}\nEditore: {editore}\nPagine: {nPagine}";
        }

        public string readingTime()
        {
            if (nPagine <= 100)
            {
                return "1h";
            } 
            else if (100 < nPagine && nPagine <= 200)
            {
                return "2h";
            } 
            else
            {
                return "+2h";
            }
        }
    }
}
