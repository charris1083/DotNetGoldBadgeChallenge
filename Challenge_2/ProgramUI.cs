using System;

namespace Challenge_2
{
    class ProgramUI
    {
        ClaimRepo _claimRepo = new ClaimRepo();
        public void RunMenu()
        {
            DateTime dateTime = new DateTime(2018, 12, 16);
            

            Console.WriteLine("Welcome to Komodo Claims dept. How can we help you today?");
            Console.ReadLine();
            bool menuRun = true;
            while (menuRun)
            {
                Console.WriteLine("Where would you like to navigate? \n1. See all claims \n2. Take care of next claim \n3. Enter new claim \n4. Exit");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        SeeAllCliams();
                        break;
                    case 2:
                        NextClaim();
                        break;
                    case 3:NewClaim();
                        break;
                    case 4:
                        menuRun = false;
                        break;
                }
            }
        }

        private void NewClaim()
        {
            Console.Clear();

            Console.WriteLine("Enter claimn Id: ");
            Claim claim = new Claim();
            claim.ClaimID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Claim type:");
            claim.ClaimType = Console.ReadLine();

            Console.WriteLine("Enter claim description: ");
            claim.ClaimDescription = Console.ReadLine();

            Console.WriteLine("Enter claim date: ");
            claim.DateOfClaim = Console.ReadLine();

            Console.WriteLine("Enter accident date: ");
            claim.DateOfIncident = Console.ReadLine();

            Console.WriteLine("Enter claim amount: ");
            claim.ClaimAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Is claim valid?: ");
            claim.IsValid = true;
            _claimRepo.AddToQueue(claim);
                
        }

        private void NextClaim()
        {
            throw new NotImplementedException();
        }

        private void SeeAllCliams()
        {
            var claim = _claimRepo.SeeQueue();
            Console.Clear();
            Console.WriteLine("Claim ID\t Claim Type\t Description\t Claim Date\t Accident Date\t Claim Amount\t Is Claim Valid");
            foreach(clai)
            Console.WriteLine($"{claim}");
            
        }
    }
}
