using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmorDePet.Modelos
{
    internal class Pet
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Especie { get; set; }

        public string Raca { get; set; }

        public int Idade { get; set; }
              
        public bool Castrado { get; set; }

        public bool Vacinacao { get; set; }

        public bool Microchipado { get; set; }

        public int Porte { get; set; }

        public string Cor { get; set; }
        public string Descricao { get; set; }

        public List<string> Fotos { get; set; }


    }
}
