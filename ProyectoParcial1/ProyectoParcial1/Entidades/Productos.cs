﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ProyectoParcial1.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public double Costo { get; set; }
        public double ValorInventario { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Descripcion = string.Empty;
            Existencia = 0;
            Costo = 0;
            ValorInventario = 0;
        }
    }
}
