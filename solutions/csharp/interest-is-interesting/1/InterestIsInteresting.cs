using System;

static class SavingsAccount
    {
        public static float InterestRate(decimal balance)
        {
            float interestRate = float.MinValue;
            switch (balance)
            {
                case var rate when rate < 0:
                    interestRate = 3.213f;
                    break;
                case var rate when rate < 1000:
                    interestRate = 0.5f;
                    break;
                case var rate when rate >= 1000 && rate < 5000:
                    interestRate = 1.621f;
                    break;
                case var rate when rate >= 5000:
                    interestRate = 2.475f;
                    break;
                default:
                    interestRate = float.MinValue;
                    break;
            }

            return interestRate;
        }

        public static decimal Interest(decimal balance)
        {
            var interestRate = SavingsAccount.InterestRate(balance);

            return ((decimal)interestRate * balance) / 100;
        }

        public static decimal AnnualBalanceUpdate(decimal balance)
        {
            var interest = SavingsAccount.Interest(balance);

            return balance + interest;
        }

        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
           var numberOfyears = 0;

            //increase balance until it gets to targetBalance	
            while (targetBalance > balance)
            {
                balance = AnnualBalanceUpdate(balance);
                numberOfyears++;
            }
            return numberOfyears;
        }
    }