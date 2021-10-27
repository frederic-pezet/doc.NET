using System;

namespace Quizz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor(White);

            int score = 0;
            string[] userAnswer = new string[10];
            string[] answer = new string[10];


            // Question 1
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Question 1 :");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Quelle est la bonne syntaxe pour afficher à l'écran \"Hello World\" en C# ?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Réponse A : System.out.println(\"\");");
            Console.WriteLine("Réponse B : cout << \"Hello World\";");
            Console.WriteLine("Réponse C : print(\"Hello World\");");
            Console.WriteLine("Réponse D : Console.WriteLine(\"Hello World\");");
            answer[0] = "D";
            Console.ForegroundColor = ConsoleColor.White;
            userAnswer[0] = Console.ReadLine().ToUpper();


            // Question 2
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Question 2 :");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Quelle est la bonne syntaxe pour écrire un commentaire ?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Réponse A : // Commentaire");
            Console.WriteLine("Réponse B : <<!-- Commentaire  -->>");
            Console.WriteLine("Réponse C : ## Commentaire ##");
            Console.WriteLine("Réponse D : {{ Commentaire }}");
            answer[1] = "A";
            Console.ForegroundColor = ConsoleColor.White;
            userAnswer[1] = Console.ReadLine().ToUpper();



            // Question 3
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Question 3 :");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Comment déclarer une variable et l'initialiser avec un entier ?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Réponse A : double x = 5;");
            Console.WriteLine("Réponse B : x = 5;");
            Console.WriteLine("Réponse C : int x = 5;");
            Console.WriteLine("Réponse D : num x = 5;");
            answer[2] = "C";
            Console.ForegroundColor = ConsoleColor.White;
            userAnswer[2] = Console.ReadLine().ToUpper();


            // Question 4
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Question 4 :");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Quel opérateur de comparaison doit-on utilisé pour vérifier que deux variables sont égales");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Réponse A : =");
            Console.WriteLine("Réponse B : <>");
            Console.WriteLine("Réponse C : ==");
            Console.WriteLine("Réponse D : =!");
            answer[3] = "C";
            Console.ForegroundColor = ConsoleColor.White;
            userAnswer[3] = Console.ReadLine().ToUpper();


            // Question 5
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Question 5 :");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Quelle est la commande pour pouvoir lire ce que l'utilisateur entre dans la console ?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Réponse A : Console.ReadLine();");
            Console.WriteLine("Réponse B : Console.LireLaLigne();");
            Console.WriteLine("Réponse C : ReadLine();");
            Console.WriteLine("Réponse D : Console.ReadLine();");
            answer[4] = "A";
            Console.ForegroundColor = ConsoleColor.White;
            userAnswer[4] = Console.ReadLine().ToUpper();


            // Question 6
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Question 6 :");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Comment ajouter une couleur de fond bleu au texte dans la console ?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Réponse A : Console.BackgroundColor = ConsoleColor.Blue;");
            Console.WriteLine("Réponse B : textebleu;");
            Console.WriteLine("Réponse C : color = blue;");
            Console.WriteLine("Réponse D : Console.WriteLine(\"blue\");");
            answer[5] = "A";
            Console.ForegroundColor = ConsoleColor.White;
            userAnswer[5] = Console.ReadLine().ToUpper();


            // Question 7
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Question 7 :");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Comment déclare-t-on un tableau de type int en C# ?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Réponse A : int[] array = new int[];");
            Console.WriteLine("Réponse B : int array[] = new int[5];");
            Console.WriteLine("Réponse C : int[] array = new int[5];");
            Console.WriteLine("Réponse D : int[5] array = new int[];");
            answer[6] = "C";
            Console.ForegroundColor = ConsoleColor.White;
            userAnswer[6] = Console.ReadLine().ToUpper();

            // Question 8
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Question 8 :");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Quel type de données est utilisé pour créer une variable qui doit stocker du texte ?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Réponse A : text ");
            Console.WriteLine("Réponse B : string ");
            Console.WriteLine("Réponse C : str");
            Console.WriteLine("Réponse D : txt");
            answer[7] = "B";
            Console.ForegroundColor = ConsoleColor.White;
            userAnswer[7] = Console.ReadLine().ToUpper();

            // Question 9
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Question 9 :");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Quelle est la propriété peut être utilisée pour trouver la longueur d'une chaine ?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Réponse A : lenght");
            Console.WriteLine("Réponse B : lenght()");
            Console.WriteLine("Réponse C : getLenght()");
            Console.WriteLine("Réponse D : Lenght");
            answer[8] = "D";
            Console.ForegroundColor = ConsoleColor.White;
            userAnswer[8] = Console.ReadLine().ToUpper();

            // Question 10
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Question 10 :");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Comment commencer à écrire une intruction if en C# ?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Réponse A :if (x>y)");
            Console.WriteLine("Réponse B :if {x>y} ");
            Console.WriteLine("Réponse C :if x>y");
            Console.WriteLine("Réponse D :if x>y;");
            answer[9] = "A";
            Console.ForegroundColor = ConsoleColor.White;
            userAnswer[9] = Console.ReadLine().ToUpper();


            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("------------------------------------- Vos Résultats ------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("");


            for (int i = 0; i < 10; i++)
            {
                int question = i + 1;
                if (answer[i] == userAnswer[i])
                {
                    score++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vous avez bien répondu à la question n°" + question);
                    Console.WriteLine("La réponse était bien : " + answer[i]);
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vous avez mal répondu à la question n°" + question);
                    Console.WriteLine("Votre réponse était : " + userAnswer[i]);
                    Console.WriteLine("La réponse était : " + answer[i]);
                    Console.WriteLine(" ");
                }

            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------- Score ----------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("");



            if (score < 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Votre score est de {score} sur 10");
                Console.WriteLine("Vous devez encore travailler.");
            }
            else if (score >= 3 && score < 6)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Votre score est de {score} sur 10");
                Console.WriteLine("Encore un effort.");
            }
            else if (score >= 6 && score < 10)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Votre score est de {score} sur 10");
                Console.WriteLine("C'est très bien.");
                var arr = new[]
                {
                        @"     /$$$$$$$  /$$$$$$$   /$$$$$$  /$$    /$$  /$$$$$$    ",
                        @"    | $$__  $$| $$__  $$ /$$__  $$| $$   | $$ /$$__  $$   ",
                        @"    | $$  \ $$| $$  \ $$| $$  \ $$| $$   | $$| $$  \ $$   ",
                        @"    | $$$$$$$ | $$$$$$$/| $$$$$$$$|  $$ / $$/| $$  | $$   ",
                        @"    | $$__  $$| $$__  $$| $$__  $$ \  $$ $$/ | $$  | $$   ",
                        @"    | $$  \ $$| $$  \ $$| $$  | $$  \  $$$/  | $$  | $$   ",
                        @"    | $$$$$$$/| $$  | $$| $$  | $$   \  $/   |  $$$$$$/   ",
                        @"    | ______ /| __ /|__/| __/ | __/   \_/    \______ /    ",
                };
                Console.WindowWidth = 160;
                Console.WriteLine("\n\n");
                foreach (string line in arr)
                    Console.WriteLine(line);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Votre score est de {score} sur 10");
                Console.WriteLine("C'est parfait.");
                var arr = new[]
                {
                        @"     /$$$$$$$$ /$$   /$$  /$$$$$$  /$$$$$$$$ /$$       / $$      /$$$$$$$$ /$$   /$$ /$$$$$$$$    ",
                        @"    | $$_____/| $$  / $$ /$$__  $$| $$_____/| $$      | $$      | $$_____/| $$$ | $$|__  $$__/    ",
                        @"    | $$      |  $$/ $$/| $$  \__/| $$      | $$      | $$      | $$      | $$$$| $$   | $$       ",
                        @"    | $$$$$    \  $$$$/ | $$      | $$$$$   | $$      | $$      | $$$$$   | $$ $$ $$   | $$       ",
                        @"    | $$__/     >$$  $$ | $$      | $$__/   | $$      | $$      | $$__ /  | $$  $$$$   | $$       ",
                        @"    | $$       /$$/\  $$| $$    $$| $$      | $$      | $$      | $$      | $$\  $$$   | $$       ",
                        @"    | $$$$$$$$| $$  \ $$|  $$$$$$/| $$$$$$$$| $$$$$$$$| $$$$$$$$| $$$$$$$$| $$ \  $$   | $$       ",
                        @"    |________/|__/  |__/ \______/ |________/|________/|________/|________/|__/  \__/   |__/       ",
                };
                Console.WindowWidth = 160;
                Console.WriteLine("\n\n");
                foreach (string line in arr)
                    Console.WriteLine(line);
            }
            Console.ForegroundColor = ConsoleColor.White;


            Console.ReadKey();
        }
    }
}



