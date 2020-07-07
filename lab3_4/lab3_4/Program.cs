using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select your Regular expressions number \n 1: Find all of the occurrences of the letter d or e [d-e] \n 2: Find all of the occurrences of the letter ‘d’ or’ e [d-e][*d]  \n 3: Find all of the occurrences of the letter ‘a’, followed by any letter, then the letter ‘a’ again [a][a-z][a] \n 4: Find all of the words that start with the letter p [ ][p][a-z]* \n 5: Find all of the words that end with the letter e [a-z]*[e][ ] \n 6: Find all of the capital letters [A-Z]");
            int caseSwitch;

            caseSwitch = int.Parse(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    string pattern = @"[d-e]";
                    string input = @"Test String:
Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden
base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies
managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored
space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister
agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can
save her people and restore freedom to the galaxy….";
                    RegexOptions options = RegexOptions.Multiline;

                    foreach (Match m in Regex.Matches(input, pattern, options))
                    {
                        Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
                    }
                    break;


                case 2:
                    string pattern1 = @"[d-e][*d]";
                    string input1 = @"Test String:
Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden
base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies
managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored
space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister
agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can
save her people and restore freedom to the galaxy….";
                    RegexOptions options1 = RegexOptions.Multiline;

                    foreach (Match m in Regex.Matches(input1, pattern1, options1))
                    {
                        Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
                    }
                    break;
                case 3:
                    string pattern2 = @"[a][a-z][a]";
                    string input2 = @"Test String:
Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden
base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies
managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored
space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister
agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can
save her people and restore freedom to the galaxy….[d-e][*d]";
                    RegexOptions options2 = RegexOptions.Multiline;

                    foreach (Match m in Regex.Matches(input2, pattern2, options2))
                    {
                        Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
                    }
                    break;
                case 4:
                    string pattern3 = @"[ ][p][a-z]*";
                    string input3 = @"Test String:
Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden
base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies
managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored
space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister
agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can
save her people and restore freedom to the galaxy….[d-e][*d]";
                    RegexOptions options3 = RegexOptions.Multiline;

                    foreach (Match m in Regex.Matches(input3, pattern3, options3))
                    {
                        Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
                    }
                    break;
                case 5:
                    string pattern4 = @"[a-z]*[e][ ]";
                    string input4 = @"Test String:
Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden
base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies
managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored
space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister
agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can
save her people and restore freedom to the galaxy….[d-e][*d]";
                    RegexOptions options4 = RegexOptions.Multiline;

                    foreach (Match m in Regex.Matches(input4, pattern4, options4))
                    {
                        Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
                    }
                    break;
                case 6:
                    string pattern5 = @"[A-Z]";
                    string input5 = @"Test String:
Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden
base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies
managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored
space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister
agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can
save her people and restore freedom to the galaxy….[d-e][*d]";
                    RegexOptions options5 = RegexOptions.Multiline;

                    foreach (Match m in Regex.Matches(input5, pattern5, options5))
                    {
                        Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
                    }
                    break;
                default:
                    Console.WriteLine("Wrong Number");
                    break;
            }
        }
    }
}