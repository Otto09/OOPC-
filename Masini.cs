using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicule
{
    class Masini : Vehicul, ICars
    {
        public float acceleratie = 10;
        public string frana;
        public string faruri;
        public string radio;
        public string portbagaj;
        public string semnalizator;
        public string dezaburitor;
        private string _stergatoareParbriz;

        public string StergatoareParbriz
        {
            get
            {
                return _stergatoareParbriz;
            }

            set
            {
                this._stergatoareParbriz = value;
            }
        }

        public Masini()
        { 

        }

        public Masini(float acceleration, string radioset, string demist)
        {
            acceleratie = acceleration;
            radio = radioset;
            dezaburitor = demist;
        }
        public void Accelereaza()
        {
            Console.WriteLine("Aceasta metoda creste acceleratia");
        }
        public void Franeaza()
        {
            Console.WriteLine("Aceasta metoda scade viteza sau opreste masina");
        }
        public void PornesteFazaScurta()
        {
            Console.WriteLine("Aceasta metoda porneste luminile de intalnire");
        }
        public void PornesteFazaLunga()
        {
            Console.WriteLine("Aceasta metoda porneste luminile de drum");
        }
        public void PornesteRadio()
        {
            Console.WriteLine("Aceasta metoda porneste aparatul de radio");
        }
        public void DeschidePortbagajul()
        {
            Console.WriteLine("Aceasta metoda deschide portbagajul masinii");
        }
        public void SemnalizeazaDreapta()
        {
            Console.WriteLine("Aceasta metoda semnalizeaza spre dreapta");
        }
        public void SemnalizeazaStanga()
        {
            Console.WriteLine("Aceasta metoda semnalizeaza spre stanga");
        }
        public void PornesteDezaburitorul()
        {
            Console.WriteLine("Aceasta metoda dezabureste parbrizul si luneta");
        }

        public void PornesteStergatorulDeParbriz()
        {
            Console.WriteLine("Aceasta metoda porneste stergatorul de parbriz");
        }

        public virtual void GetTurbo() // Polimorfism
        {
            Console.WriteLine("This method is for normal speed");
        }
    }
}
