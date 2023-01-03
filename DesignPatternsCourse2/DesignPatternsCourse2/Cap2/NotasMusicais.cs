using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCourse2.Cap2
{
    public class NotasMusicais
    {
        private static Dictionary<string, INota> notas = new Dictionary<string, INota>
        {
            { "do", new Do() },
            { "re", new Re() },
            { "mi", new Mi() },
            { "fa", new Fa() },
            { "sol", new Sol() },
            { "la", new Si() }
        };

        public INota Pega(string notaNome)
        {
            return notas[notaNome];
        }
    }
}
