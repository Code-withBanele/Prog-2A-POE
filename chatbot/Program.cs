using System;
using System.Buffers.Text;
using System.Media;
using System.Net.NetworkInformation;
using System.Security;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace chatbot
{
    class Program
    {
        static void Main(string[] args)
        {




            try
            {
                var Loc = @"C:/Users/Siviwe Mjayezi/Desktop/rr/year 2/prog 6221 c#/projects c#/chatbot/chatbot/welcome.wav.wav";

                SoundPlayer player = new SoundPlayer(Loc);
                player.Play();

                Console.WriteLine("*********Ceasar AI Cyber security Awareness BOT V1.0");

                Console.WriteLine("\n" + "Please enter your name: ");
                var Name = Console.ReadLine();
                Console.WriteLine("\n" + "Please enter your Last name: ");
                var LastName = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("\n" + "Welcome to Ceasar AI Cyber security Awareness BOT V1.0 " + Name + " " + LastName);
                Console.WriteLine("Ask me anything about cyber security.");
                Console.WriteLine();
                
                bool running = true;

               while (running)
                {
                    Console.WriteLine("\n"+"You: ");
                    var input = Console.ReadLine().ToLower();


                    if (input.Contains("phishing"))
                {


                        Console.WriteLine("Ceasar: "+ "Phishing is a type of cyber attack that uses disguised email as a weapon. The goal is to trick the email recipient into believing that the message is something they want or need — a request from their bank, for instance, or a note from someone in their company — and to click a link or download an attachment. ");
                        Console.WriteLine("Read more at: https://en.wikipedia.org/wiki/Phishing");

                }
                else if (input.Contains("password security"))
                {
                        Console.WriteLine("Ceasar: " + "Password security refers to the practices and measures taken to protect passwords from unauthorized access and use. This includes creating strong passwords, using password managers, enabling two-factor authentication, and regularly updating passwords to enhance security. ");
                        Console.WriteLine("Read more at: https://en.wikipedia.org/wiki/Phishing");
                    }
                else if (input.Contains("information security")||input.Contains("info security")||input.Contains("infosec"))
                {
                    Console.WriteLine("Ceasar: " + "Information security is the discipline concerned with safeguarding information systems and data from unauthorized access, disclosure, alteration, or destruction, guided by the principles of confidentiality, integrity, and availability ");
                    Console.WriteLine("Read more at: https://en.wikipedia.org/wiki/Phishing");
                    }
                else if (input.Contains("malaware"))
                {
                    Console.WriteLine("Ceasar: " + "Malware, short for malicious software, is any software intentionally designed to cause damage to a computer, server, client, or computer network. It can take various forms such as viruses, worms, trojans, ransomware, spyware, adware, and more. ");
                    Console.WriteLine("Read more at: https://www.microsoft.com/en-us/security/business/security-101/what-is-malware");
                    }

                else if (input.Contains("application security"))
                 {
                   Console.WriteLine("Ceasar: " + "Application security involves the implementation of security measures throughout the software development lifecycle to identify, prevent, and mitigate vulnerabilities within applications.");
                   Console.WriteLine("Read more at: ");
                    }
                    else if (input.Contains("cryptography"))
                    {
                        Console.WriteLine("Ceasar: " + "Cryptography is the practice of securing information through mathematical techniques and algorithms that enable encryption, decryption, and authentication to protect data confidentiality and integrity.");
                        Console.WriteLine("Read more at: https://en.wikipedia.org/wiki/Cryptography");
                    }

                    else if (input.Contains("Security policies") || input.Contains("governace"))
                    {
                        Console.WriteLine("Ceasar: " + "Security policies and governance define the structured framework of rules, standards, and procedures that guide an organization in managing and enforcing information security practices.");
                        Console.WriteLine("Read more at:https://www.cisa.gov/topics/cybersecurity-best-practices/cybersecurity-governance");
                    }
                    else if (input.Contains("access control") || input.Contains("authentication"))
                    {
                        Console.WriteLine("Ceasar: " + "Access control and authentication refer to the processes used to regulate and verify user identities, ensuring that only authorized individuals are granted access to systems and resources.");
                        Console.WriteLine("Read more at: https://www.microsoft.com/en-us/security/business/security-101/what-is-access-control");
                        Console.WriteLine("Read more at: https://www.identity.org/the-role-of-authentication-and-authorization-in-access-control/ ");
                    }
                    else if (input.Contains("social engineering"))
                {
                    Console.WriteLine("Ceasar: " + "Social engineering is a manipulation technique that exploits human error to gain private information, access, or valuables. It often involves tricking individuals into breaking normal security procedures.");
                    Console.WriteLine("Read more at: https://en.wikipedia.org/wiki/Social_engineering_(security) ");
                    }
                else if (input.Contains("network security"))
                {
                    Console.WriteLine("Ceasar: " + "Ceasar: " + "Ceasar: " + "Network security involves policies and practices adopted to prevent and monitor unauthorized access, misuse, modification, or denial of a computer network and network-accessible resources. ");
                    Console.WriteLine("Read more at: https://www.cisco.com/site/us/en/learn/topics/security/what-is-network-security.html ");
                    }






            }

            }



            catch (FormatException e)
            {

                Console.WriteLine(e.Message);



            }



            



            
        }


   


    }

}
