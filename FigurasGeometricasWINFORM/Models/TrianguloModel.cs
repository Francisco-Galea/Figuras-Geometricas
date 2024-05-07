﻿using FigurasGeometricasWINFORM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricasWINFORM.Models
{
    public class TrianguloModel : ICalculable, IFigura
    {
        private string nombre { get; set; }
        private int cantidadLados { get; set; }
        private float longitudLado { get; set; }
        

        public TrianguloModel(string nombre, int cantidadLados, float longitudLado)
        {
            this.nombre = nombre;
            this.cantidadLados = cantidadLados;
            this.longitudLado = longitudLado;            
        }

        public string Nombre
        {
           set { nombre = value; }
           get { return nombre; }        
        }

        public float LongitudLado
        {
            set { longitudLado = value; }
            get { return  longitudLado; }
        }

        public int CantidadLados
        {
            set { cantidadLados = value; }
            get { return cantidadLados; }
        }

        public float calcularAltura()
        {
            return (float)(Math.Sqrt(3) / 2) * longitudLado;
        }

        public float calcularSuperficie()
        {
            return (float)(Math.Pow(longitudLado, 2) * Math.Sqrt(3)) / 4;
        }

        public float calcularPerimetro()
        {
            return (float)longitudLado * 3;
        } 
    }
}
