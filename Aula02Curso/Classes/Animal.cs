using Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{ 
        public abstract class Animal
        {
            public string Raça;
            public string Peso;
            public string Tipo;

            public abstract void Comer();
            public string Correr()
            {
                return "O animal está correndo loucamente";
            }
        }
    }

