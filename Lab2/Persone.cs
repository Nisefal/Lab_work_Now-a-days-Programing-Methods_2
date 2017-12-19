using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    class Persone
    {
        public string Name_SName { get; private set; }
        public string PC { get; private set; }

        internal Lab2.MyFacade MyFacade
        {
            get => default(Lab2.MyFacade);
            set
            {
            }
        }

        public Persone(string name, string code)
        {
            Name_SName = name;
            PC = code;
        }
    }
}
