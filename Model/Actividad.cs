﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Actividad
    {
        private int id;
        private string nombre;
        private string descripcion;

        protected Actividad(int id, string nombre, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
