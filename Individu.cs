using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP4
{
    public class Individu
    {
        //question 1
        protected int code;
        protected string nom;
        protected string prenom;
        
        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        
        public Individu()
        {
            Random random = new Random();
            this.code = random.Next(10, 500);
            this.nom = "Inconnu";
            this.prenom = "Inconnu";
        }
        //constructeur d'initialisation
        public Individu(int code, string nom, string prenom)
        {
            this.code = code;
            this.nom = nom;
            this.prenom = prenom;
        }

        public virtual void Afficher() 
        {
            Console.WriteLine("Code : "+ code);
            Console.WriteLine("Nom : "+ nom);
            Console.WriteLine("Prenom : "+ prenom);
        }

    }
}
