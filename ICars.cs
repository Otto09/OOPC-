using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicule
{
    interface ICars
    {
        void Accelereaza();
        void Franeaza();
        void PornesteFazaScurta();
        void PornesteFazaLunga();
        void PornesteRadio();
        void DeschidePortbagajul();
        void SemnalizeazaDreapta();
        void SemnalizeazaStanga();
        void PornesteDezaburitorul();
        void PornesteStergatorulDeParbriz();
    }
}
