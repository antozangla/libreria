using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class Libro
    {
        private string autore;
        private string titolo;
        private string annoPubblicazione;
        private string editore;
        private int nPagine;

        public Libro(string autore, string titolo, string annoPubblicazione, string editore, int nPagine)
        {
            this.autore = autore;
            this.titolo = titolo;
            this.annoPubblicazione = annoPubblicazione;
            this.editore = editore;
            this.nPagine = nPagine;
        }

        public string getAutore()
        {
            return autore;
        }

        public string getTitolo()
        {
            return titolo;
        }

        public string getAnnoPubblicazione()
        {
            return annoPubblicazione;
        }

        public string getEditore()
        {
            return editore;
        }

        public int getNPagine()
        {
            return nPagine;
        }

        public void modificaAutore(string nuovoAutore)
        {
            this.autore = nuovoAutore;
        }

        public void modificaTitolo(string nuovoTitolo)
        {
            this.titolo= nuovoTitolo;
        }

        public void modificaAnnoPubblicazione(string nuovoAnnoPubblicazione)
        {
            this.annoPubblicazione = nuovoAnnoPubblicazione;
        }

        public void modificaEditore(string nuovoEditore)
        {
            this.editore = nuovoEditore;
        }

        public void modificaNPagine(int nuovoNPagine)
        {
            this.nPagine = nuovoNPagine;
        }

        

    }
}
