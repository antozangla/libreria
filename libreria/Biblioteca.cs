using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    class Biblioteca
    {
        string nome;
        string indirizzo;
        string orarioApertura;
        string orarioChiusura;
        List<Libro> listaLibri = new List<Libro>();

        public Biblioteca(string nome, string indirizzo, string orarioApertura, string orarioChiusura)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.orarioApertura = orarioApertura;
            this.orarioChiusura = orarioChiusura;
        }

        public void aggiungiLibro(Libro libro)
        {
            listaLibri.Add(libro);
        }

        public string ricercaLibro(string titolo)
        {
            for(int i=0; i < listaLibri.Count; i++)
            {
                if(listaLibri[i].getTitolo() == titolo)
                {
                    return "L'autore del libro è " + listaLibri[i].getAutore() + ", l'editore è " + listaLibri[i].getEditore() + ", il numero delle pagine è " + listaLibri[i].getNPagine().toString() + " ed è stato pubblicato nel " + listaLibri[i].getAnnoPubblicazione();
                }
                
            }
            return "Libro non trovato";
        }
    }
}
