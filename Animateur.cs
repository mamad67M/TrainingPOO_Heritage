using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP4
{
    public class Animateur : Individu
    {
        private string diplome;
        private string specialite;
        public string Diplome
        {
            get { return diplome; }
            set { diplome = value; }
        }
        public string Specialite
        {
            get { return specialite; }
            set { specialite = value; }
        }
        //Nontion d'heritage
        public Animateur() : base()
        {
                
        }
        public Animateur(int code, string nom, string prenom, string a, string s) : base(code, nom, prenom)
        {
            this.diplome = a;
            this.specialite = s;
        }
        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Diplome : " + diplome);
            Console.WriteLine("Specialite : " + specialite);
        }





    }
}
