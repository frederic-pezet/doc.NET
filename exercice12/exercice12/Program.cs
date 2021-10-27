using System;

namespace exercice12
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "username";
            string password = "motdepasse";
            string userLogin;
            string userPassword;

            Console.WriteLine("Veullez entrer votre pseudo");
            userLogin = Console.ReadLine();

            Console.WriteLine("Veuillez entrer votre mot de passe");
            userPassword = Console.ReadLine();

            if (userLogin == login && userPassword == password)
            {
                Console.WriteLine("Bienvenue à la Manu le Havre. ");
            }
            else
            {
                Console.WriteLine("Mauvais identifiant ou mauvais mot de passe");
            }
        }
    }
}
