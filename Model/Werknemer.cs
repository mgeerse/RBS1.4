using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Werknemer
    {
        public int Id { get; }
        public int Logincode { get; set; }
        public string Naam { get; set; }
        public WerknemerType Type { get; set; }

    }

    enum WerknemerType
    {
        Administratie,
        Barman,
        Kok,
        Bediende,
    }
}
