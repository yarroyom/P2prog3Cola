using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor02
{
    class ListSong
    {
        public Cancion inicio;
        protected int fin;
        private static int MAXTAMQ = 3;
        protected int frente;
        protected object[] listacola;

        public Cancion Inicio
        {
            get { return inicio; }
        }
        public ListSong()
        {
            frente = 0;
            fin = -1;
            listacola = new object[MAXTAMQ];
        }
        //private void FirstSong(string nombre, string artista, string directorio) //Se crea la Primera persona que se ingresa
        //{
        //    Cancion nuevo = new Cancion();
        //    nuevo.Titulo = nombre;
        //    nuevo.Artista = artista;
        //    nuevo.Directorio = directorio;

        // //   nuevo.siguiente = nuevo; //lista circular 
        // //   nuevo.anterior = nuevo;
        //   inicio = nuevo;
        //  }

        public void NextSong(string nombre, string artista, string directorio) //se define siguiente persona para que avance
        {
            
            Cancion nuevo = new Cancion();
            nuevo.Titulo = nombre;
            nuevo.Artista = artista;
            nuevo.Directorio = directorio;

            if (!colallena())
            {
                 // NextSong(nombre, artista, directorio); //si es igual a vacio se miestra lo que tenia de ultimo
                listacola[++fin] = nuevo;
            }
            else
            {
               

                throw new Exception("cola llena");
            }
        }


        public string FindSong(string title) //Busca los contatos que tiene cada nodo 
        {
            Cancion temporal = new Cancion();   //se cra un temporal solo para que recorra los nodo 
            temporal = inicio;
            while (temporal != null) //mientras que temporal sea diferente de vacio debera mostrar lo que le pidan
            {
                if (temporal.Titulo.Equals(title))
                {
                    return temporal.Directorio;  //retorna el valor que encuentre en el temporal
                }
                else
                {
                    temporal = temporal.siguiente; //para que continue movinendose el temporal 
                }
            }
            return null;
        }

        public string Search(string title) //Busca los contatos que tiene cada nodo 
        {
            Cancion temporal = new Cancion();   //se cra un temporal solo para que recorra los nodo 
            temporal = inicio;
            while (temporal != null) //mientras que temporal sea diferente de vacio debera mostrar lo que le pidan
            {
                if (temporal.Titulo.Equals(title))
                {
                    return temporal.Directorio;  //retorna el valor que encuentre en el temporal
                }
                else
                {
                    temporal = temporal.siguiente; //para que continue movinendose el temporal 
                }
            }
            return null;
        }

        //public void delete() //Busca los contatos que tiene cada nodo 
        //{
        //    Cancion actual = new Cancion();   //se cra un temporal solo para que recorra los nodo 
        //    Cancion temp = new Cancion();
        //    actual = inicio;
        //    while (actual != null) //mientras que temporal sea diferente de vacio debera mostrar lo que le pidan
        //    {
        //        inicio = null;
        //        temp = actual.siguiente;
        //        actual = null;
        //    }
        //}


        public Boolean colallena()
        {
            return fin == MAXTAMQ - 1;

        }
        public Boolean colavacia()
        {
            return frente > fin;

        }
        public void delete()
        {
            frente = 0;
            fin = -1;
        }
    }
      

}

