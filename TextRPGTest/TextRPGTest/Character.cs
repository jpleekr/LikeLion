using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGTest
{
    abstract class Character
    {
        public string strName { get; set; }
        public int nHp { get; set; }
        public int nAttack { get; set; }

        public abstract void SetDamage(int Attack);

        public abstract void Render();
        

    }
}
