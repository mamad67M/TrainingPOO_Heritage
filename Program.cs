// See https://aka.ms/new-console-template for more information
using POO_TP4;

Individu i1 = new Individu(1,"Khalil","Morad");
Animateur i2 = new Animateur(2, "Lahlou", "Nabil", "DESS","Mathématique");
Participant i3 = new Participant(3, "Talal", "Yazid", "TDI", 5);
Console.WriteLine("------------Affichage des objets : ");
i1.Afficher();
Console.WriteLine("---------------");
i2.Afficher();
Console.WriteLine("---------------");
i3.Afficher();
i3.Absence();
i3.Absence();
Console.WriteLine("---------------");

Console.WriteLine("------spé I2 en physique---------");
i2.Specialite = "Physique";
i1.Afficher();
i2.Afficher();
i3.Afficher();
Console.WriteLine("-----nb participant----------");
Console.WriteLine("le nobre de participant est : "+ Participant.Nbre_Participant());