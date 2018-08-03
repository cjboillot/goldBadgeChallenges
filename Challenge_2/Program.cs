using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaimRepository claimRepo = new ClaimRepository();
            Queue<Claim> ClaimItems = claimRepo.GetClaimsList();

            DateTime c1a = new DateTime(2018, 06, 1);
            DateTime c1b = new DateTime(2018, 06, 20);
            DateTime c2a = new DateTime(2018, 06, 1);
            DateTime c2b = new DateTime(2018, 07, 1);
            DateTime c3a = new DateTime(2018, 06, 29);
            DateTime c3b = new DateTime(2018, 07, 01);
            DateTime c4a = new DateTime(2018, 06, 17);
            DateTime c4b = new DateTime(2018, 06, 22);

            Claim claim1 = new Claim(1, "Car", "Accident on highway", 450, c1a, c1b);
            Claim claim2 = new Claim(2, "Truck", "Accident on highway", 450, c2a, c2b);
            Claim claim3 = new Claim(3, "Car", "Accident on highway", 450, c3a, c3b);
            Claim claim4 = new Claim(4, "Bus", "Accident on street", 450, c4a, c4b);

            claimRepo.AddClaimToList(claim1);
            claimRepo.AddClaimToList(claim2);
            claimRepo.AddClaimToList(claim3);
            claimRepo.AddClaimToList(claim4);

            Console.WriteLine("ClaimID Type \t Description             Amount      DateOfAccident              DateOfClaim                      IsValid \n ");

            claimRepo.PrintList(claimRepo.GetClaimsList());

            while (true)
            {

                Console.WriteLine("Would you like to 1.Add a Claim, 2. Process the current claim, or 3. List all claims?");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    while (true)
                    {

                        Console.WriteLine("What is the claim ID:");
                        int claimID = int.Parse(Console.ReadLine());

                        Console.WriteLine("What is the vechile type:");
                        string type = Console.ReadLine();

                        Console.WriteLine("Describe the accident");
                        string description = Console.ReadLine();

                        Console.WriteLine("What is amount");
                        int amount = int.Parse(Console.ReadLine());

                        Console.WriteLine("What was the date of the accident?");
                        DateTime dateAccident = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("When was the claim filed?");
                        DateTime dateClaim = DateTime.Parse(Console.ReadLine());

                        Claim userClaim = new Claim(claimID, type, description, amount, dateAccident, dateClaim);
                        claimRepo.AddClaimToList(userClaim);

                        Console.WriteLine("Do you want to add annother claim?");
                        string theAnswer = Console.ReadLine();
                        if (theAnswer == "y")
                        {
                            continue;
                        }
                        else if (theAnswer == "n")
                        {
                            claimRepo.PrintList(claimRepo.GetClaimsList());

                            break;
                        }
                    }
                }

                else if (choice == "2")
                {
                    while (true)
                    {
                        Console.WriteLine(claimRepo.GetClaimsList().Peek());
                        Console.WriteLine("Press enter to confirm removal of current claim.");
                        string item = Console.ReadLine();
                        claimRepo.CurrentClaimFinished();
                        claimRepo.PrintList(claimRepo.GetClaimsList());

                        backToPrompt:
                        Console.WriteLine("Do you want to remove another claim? y/n");
                        string theAnswer = Console.ReadLine();
                        if (theAnswer == "y")
                        {
                            continue;
                        }

                        else if (theAnswer == "n")
                        {
                            Console.Clear();
                            claimRepo.PrintList(claimRepo.GetClaimsList());

                            break;
                        }

                        else goto backToPrompt;
                    }
                }

                else if (choice == "3")
                {
                    claimRepo.PrintList(claimRepo.GetClaimsList());
                    Console.ReadLine();
                }
            }
        }
    }
}