﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto_a_Ponto
{
    class distancia
    {
        private double _X, _Y;
        public double X { set => _X =  value; get => _X; }
        public double Y { set => _Y = value; get => _Y; }
        public double Distancia(distancia P)
        {
            return Math.Sqrt(Math.Pow(P.X - _X, 2) + Math.Pow(P.Y - _Y, 2));
        }

    }
}
