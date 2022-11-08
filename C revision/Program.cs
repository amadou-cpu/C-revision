
using System;

namespace C_revision
{
    class Program
    {
        static void Main(string[] args)
        {
            //déclarations
            int âge;

            //affichage de l'âge
            Console.Write("entre un âge");
            âge = int.Parse(Console.ReadLine());

            //condition
            if (âge >= 18)
            {
                Console.Write("vous êtes majeur");



            }
            else
            {
                Console.Write("vous êtes mineur ");
            }  
            //l'âge de majorité
                Console.WriteLine("vous serez majeur dans " + (18 - âge) + " ans");
                Console.ReadLine();
            
}
        }
    }

