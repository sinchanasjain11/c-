using System;

namespace BankDemo
{
    // ================= Base Class =================
    class BankAccount
    {
        // 1. Public – accessible everywhere
        public string AccountHolder;

        // 2. Private – accessible only inside BankAccount
        private double Balance;

        // 3. Protected – accessible in BankAccount and derived classes
        protected string BankName;

        // 4. Internal – accessible anywhere in the same assembly
        internal string IFSCCode;

        // 5. Protected Internal – accessible in same assembly
        //     OR derived classes in other assemblies
        protected internal string Branch;

        // 6. Private Protected – accessible in derived classes
        //     but ONLY in the same assembly
        private protected string AccountType;

        // Constructor
        public BankAccount(string holder, double balance, string bank,
                           string ifsc, string branch, string type)
        {
            AccountHolder = holder;
            Balance = balance;
            BankName = bank;
            IFSCCode = ifsc;
            Branch = branch;
            AccountType = type;
        }

        // Public method to show details inside the class
        public void ShowBankAccountDetails()
        {
            Console.WriteLine("=== Inside BankAccount Class ===");
            Console.WriteLine($"Public           : Account Holder = {AccountHolder}");
            Console.WriteLine($"Private          : Balance = {Balance}");
            Console.WriteLine($"Protected        : Bank Name = {BankName}");
            Console.WriteLine($"Internal         : IFSC Code = {IFSCCode}");
            Console.WriteLine($"ProtectedInternal: Branch = {Branch}");
            Console.WriteLine($"PrivateProtected : Account Type = {AccountType}");
            Console.WriteLine();
        }
    }

    // ============= Derived Class =============
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(string holder, double balance, string bank,
                              string ifsc, string branch, string type)
            : base(holder, balance, bank, ifsc, branch, type)
        { }

        public void ShowAccessibleMembers()
        {
            Console.WriteLine("=== Inside SavingsAccount (Derived Class) ===");
            Console.WriteLine($"Public           : {AccountHolder}");
            // Console.WriteLine(Balance); // ❌ Not accessible (private)
            Console.WriteLine($"Protected        : {BankName}");         // ✅
            Console.WriteLine($"Internal         : {IFSCCode}");         // ✅ (same assembly)
            Console.WriteLine($"ProtectedInternal: {Branch}");           // ✅
            Console.WriteLine($"PrivateProtected : {AccountType}");      // ✅ (derived + same assembly)
            Console.WriteLine();
        }
    }

    // ============= Non-Derived Class in Same Assembly =============
    class OtherClass
    {
        public void ShowAccessibleMembers(BankAccount acc)
        {
            Console.WriteLine("=== Inside OtherClass (Non-Derived, Same Assembly) ===");
            Console.WriteLine($"Public           : {acc.AccountHolder}");
            // Console.WriteLine(acc.Balance);      // ❌ Private
            // Console.WriteLine(acc.BankName);     // ❌ Protected
            Console.WriteLine($"Internal         : {acc.IFSCCode}");      // ✅ Same assembly
            Console.WriteLine($"ProtectedInternal: {acc.Branch}");        // ✅ Same assembly
            // Console.WriteLine(acc.AccountType);  // ❌ Private Protected
            Console.WriteLine();
        }
    }

    // ================= Main Program =================
    class Program
    {
        static void Main()
        {
            BankAccount baseAcc = new BankAccount(
                holder: "Alice",
                balance: 50000,
                bank: "National Bank",
                ifsc: "NATB0001234",
                branch: "City Center",
                type: "Savings"
            );

            SavingsAccount savings = new SavingsAccount(
                holder: "Bob",
                balance: 25000,
                bank: "National Bank",
                ifsc: "NATB0005678",
                branch: "Uptown",
                type: "Savings"
            );

            OtherClass other = new OtherClass();

            // Show details inside each context
            baseAcc.ShowBankAccountDetails();   // Inside base class
            savings.ShowAccessibleMembers();    // Inside derived class
            other.ShowAccessibleMembers(baseAcc); // Inside non-derived same-assembly class
        }
    }
}
