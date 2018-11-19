using System;

namespace Challenge_2
{
    class ProgramUI
    {
        ClaimRepo _claimRepo = new ClaimRepo();
        public void RunMenu()
        {
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
                        NextCLaimInQueue();
                        break;
                    case 3:
                        NewClaim();
                        break;
                    case 4:
                        menuRun = false;
                        break;
                }
            }
        }

        private void SeeAllCliams()
        {
            var claim = _claimRepo.PeekQueue();
            Console.Clear();
            Console.WriteLine("Claim ID\t Claim Type\t Description\t Claim Date\t Accident Date\t Claim Amount\t Is Claim Valid");
            foreach (Claim newClaim in _claimRepo.SeeQueue())
            {
                Console.WriteLine($"{newClaim.ClaimID}, {newClaim.ClaimType}, {newClaim.ClaimDescription}, {newClaim.DateOfClaim}, {newClaim.DateOfIncident}, {newClaim.ClaimAmount}, {newClaim.IsValid}");
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

            claim.IsValid = _claimRepo.GetBool(claim);

            _claimRepo.AddToQueue(claim);

        }

        private void NextCLaimInQueue()
        {
            Claim claimResolved = new Claim();
            Console.WriteLine("Want to resolve your claim?  (y/n)");
            var input = Console.ReadLine();
            if (input == "y")
            {
                var claim = _claimRepo.PeekQueue();
                Console.WriteLine($"{claim.ClaimID}, {claim.ClaimType}, {claim.ClaimDescription}, {claim.DateOfClaim}, {claim.DateOfIncident}, {claim.ClaimAmount}, {claim.IsValid}");

            }
            else
            {
                claimResolved.IsValid = false;
            }
        }
    }
}