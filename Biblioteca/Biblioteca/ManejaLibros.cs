﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ManejaLibros
    {
        private Dictionary<string, Libro> Libros;

        public ManejaLibros()
        {
            Libros = new Dictionary<string, Libro>();
        }

        public void Agregar(string ISBN, Libro L)
        {
            Libros.Add(ISBN,L);
        }

        public string[] ObtenISBN()
        {
            int c = 0;
            string[] ArregloISBN = new string[Libros.Count];

            foreach (KeyValuePair<string,Libro> item in Libros)
            {
                ArregloISBN[c] = item.Key;
                c++;
            }

            return ArregloISBN;

        }

        public bool VerificaISBN(string ISBN)
        {
            if (Libros.ContainsKey(ISBN))
                return true;

            return false;
        }

        public Libro ObtenLibroPorISBN(string ISBN)
        {
            Libro L=null;

            if (!VerificaISBN(ISBN))
                return L;

            L = Libros[ISBN];

            return L;
        }

    }
}