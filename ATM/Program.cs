namespace ATM
{
    public class Program
    {

        public static decimal balance = 1000;
        public static void Main()
        {
            userInterFace();
        }
        public static void userInterFace()
        {
            Console.WriteLine("choose a transaction proccess between 1,2,3,4:");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2.  Withdraw ");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. exit");
            int choosen = Convert.ToInt32(Console.ReadLine());
            if (choosen == 1)
            {
                Console.WriteLine("your balance is:");

                Console.WriteLine(ViewBalance());
                userInterFace();
            }
            if (choosen == 2)
            {
                Console.WriteLine("write the ammount you want to withdraw:");
                decimal draw = Convert.ToDecimal(Console.ReadLine());
                Withdraw(draw);
                userInterFace();
            }
            if (choosen == 3)
            {
                Console.WriteLine("type the ammount you want to deposite:");
                decimal dep = Convert.ToDecimal(Console.ReadLine());
                Deposit(dep);
                userInterFace();
            }
            if (choosen == 4)
            {
                Environment.Exit(0);
            }

        }
        public static decimal ViewBalance()
        {
            return balance;
        }
        public static decimal Withdraw(decimal draw)

        {
            if (balance == 0 || balance < draw)
            {

                Console.WriteLine(" the balance ammount is too low");
                return 0;
            }
            else
            {
                balance = balance - draw;
                return 1;
            }

        }
        public static decimal Deposit(decimal dep)

        {
            if (dep < 0)
            {

                Console.WriteLine(" cannot deposit a negative number");
                return 0;
            }
            else
            {
                balance = balance + dep;
                return 1;
            }

        }


    }
}



