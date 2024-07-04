using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    public class exec1
    {
        public int EstoqueMedio { get; set; }
        public void calcularEstoque(int quantidade_min, int quantidade_max)
        {
            EstoqueMedio = quantidade_min + quantidade_max % 2;
        }
    }
}
