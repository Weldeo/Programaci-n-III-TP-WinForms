﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Marca
    { 
        public int Id { get; }
        public string Descripcion { get; }  




        public Marca(int id , string descripcion) { 
       
            Id = id;
           Descripcion = descripcion;
        }

    }
}
