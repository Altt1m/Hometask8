namespace Hometask8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            string answer;
            string[] words = { "аварія", "бандит", "галузь", "дозвіл" };

            do
            {
                Console.Clear();
                Console.Write("Давайте пограємо в гру в слова? <y/n> ");
                answer = Console.ReadLine();

            } while (answer != "y" && answer != "n");

            do
            {
                if (answer == "n")
                {
                    Console.WriteLine("Зрозумів. На все добре!");
                    break;
                }

                if (answer == "y")
                {
                    Console.WriteLine("Вгадай моє таємне слово.\n" +
                                      "Містить 6 букв, причому вгадувати можна по одній букві за раз.\n" +
                                      "Вам дано 6 неправильних здогадок.");

                    string secretWord = words[new Random().Next(words.Length)];
                    string guessedWord = new string('_', secretWord.Length);
                    string wrongGuesses = "";
                    int tries = 6;

                    while (tries > 0 && guessedWord.Contains("_"))
                    {
                        Console.WriteLine($"\nВаше слово: {guessedWord}");
                        Console.WriteLine($"Неправильні варіанти: {wrongGuesses}");
                        Console.WriteLine($"Залишилося {tries} неправильних варіантів");
                        Console.Write("Вгадайте букву: ");
                        string letter = Console.ReadLine();

                        if (letter.Length == 1)
                        {
                            if (secretWord.Contains(letter))
                            {
                                Console.Clear();
                                Console.WriteLine("Правильно!");
                                for (int i = 0; i < secretWord.Length; i++)
                                {
                                    if (secretWord[i] == letter[0])
                                    {
                                        guessedWord = guessedWord.Remove(i, 1).Insert(i, letter);
                                    }
                                }  
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Неправильно!");
                                tries--;
                                wrongGuesses += letter + " ";
                            }
                        }
                    }

                    if (!guessedWord.Contains("_"))
                    {
                        Console.WriteLine($"Вітаю! Ви вгадали слово: {guessedWord}");
                    }
                    else
                    {
                        Console.WriteLine($"На жаль, ви не вгадали слово. Таємним словом було: {secretWord}");
                    }

                    do
                    {
                        Console.Write("\nДавайте грати ще? <y/n> ");
                        answer = Console.ReadLine();
                    }
                    while (answer != "y" && answer != "n");

                    if (answer == "y")
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (answer == "n")
                    {
                        Console.WriteLine("Успіхів!");
                        break;
                    }


                }


            } while (true);





            }
    }
}