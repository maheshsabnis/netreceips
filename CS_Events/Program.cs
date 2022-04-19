using System;

namespace CS_Events
{
    //1. lets define a delegate
    public delegate void TransactionHandler(double amount);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Events");

            Banking b = new Banking(90000);
            // Subscribe to the Listener and pass bank instance to it

            TransactionEventListener listener = new TransactionEventListener (b);
            Console.WriteLine($"Initial Net Balalce is = {b.GetNetbalance()}");
            b.Deposite(60000);
            Console.WriteLine($"Net Balalce After Deposit is = {b.GetNetbalance()}");
            b.Withdrawal(145000);
            Console.WriteLine($"Net Balalce After Withdrawal is = {b.GetNetbalance()}");


            Console.ReadLine(); 
        }
    }

    /// <summary>
    /// Domain Class
    /// </summary>

    public class Banking
    {
        double NetBalance;

        // 2. define events to notify OverBalance as well as UnderBalance

        public event TransactionHandler OnOverBalalce;
        public event TransactionHandler OnUnderBalance;

        /// <summary>
        /// Paramneterized Constructor
        /// </summary>
        /// <param name="balance"></param>
        public Banking(double balance)
        {
            NetBalance = balance;   
        }

        public void Deposite(double tramt)
        {
            NetBalance+=tramt;
            // 3. Raise Event on Condition
            if (NetBalance >= 120000)
            {
                OnOverBalalce(NetBalance);
            }
        }

        public void Withdrawal(double tramt)
        {
            NetBalance -= tramt;
            // 3.  Raise Event on Condition
            if (NetBalance < 10000)
            {
                OnUnderBalance(NetBalance);
            }
        }

        public double GetNetbalance()
        { 
            return NetBalance;
        }

    }

    public class TransactionEventListener
    {
        // The Listener class MUST have in instance 
        // of the class that is raising an event
        Banking bank;

        /// <summary>
        /// 4. The Constructor will accept an instance of the
        /// Banking class from the client so that Notification can be send to the client
        /// </summary>
        /// <param name="b"></param>
        public TransactionEventListener(Banking b)
        {
            bank = b;

            // 5. Subscribe to the Event so that notification
            // can be generated

            bank.OnOverBalalce += Bank_OnOverBalalce;
            bank.OnUnderBalance += Bank_OnUnderBalance;
                 
        }
        /// <summary>
        /// The Subscription Method
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Bank_OnUnderBalance(double amount)
        {
            Console.WriteLine($"Dear Sir/Madam, your current net balance is Rs.{amount}/-");
            Console.WriteLine("Please make sure that minimum Rs.10000/- is maintained in account");
        }

        /// <summary>
        /// The Subscription Method
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Bank_OnOverBalalce(double amount)
        {
            Console.WriteLine($"Dear Sir/Madam, your current net balance is Rs.{amount}/-");
            double TaxableAmount = amount - 120000;
            Console.WriteLine($"It is Rs.{TaxableAmount}/- as Taxabnle amount");
            double Tax = TaxableAmount * 0.2;
            Console.WriteLine($"Please pat Rs. {Tax}/- tax Else Mr. Modi will catch you.");
        }
    }
}
