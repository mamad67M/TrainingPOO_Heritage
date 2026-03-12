using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP4
{
    public class Participant : Individu
    {
       private string section;
       private int nbAbs;
        public static int nbParticipants = 0;
        public string Section
       {
           get { return section; }
           set { section = value; }
        }
        public int NbAbs
        {
            get { return nbAbs; }
            set { nbAbs = value; }
        }

        public Participant() : base()
        {
            nbParticipants++;
        }
        public Participant(int code, string nom, string prenom, string s, int n) : base(code, nom, prenom)
        {
            this.section = s;
            this.nbAbs = n;
            nbParticipants++;
        }
        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Section : " + section);
            Console.WriteLine("Nombre d'absences : " + nbAbs);
        }
        //question 7
        public void Absence()
        {
            nbAbs++;
        }

        //question 8
        public static int Nbre_Participant()
        { 
            return nbParticipants;
        }
    }
}
