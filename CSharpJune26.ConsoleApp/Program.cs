// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

TransferService service = new TransferService();
string message = service.WalletTransfer("1234567890", "0987654321", 10000);
Console.WriteLine(message);

message = service.WalletTransfer("2234567890", "9999999999", 20000);
Console.WriteLine(message);

message = service.WalletTransfer("9999999999", "2234567890", 30000);
Console.WriteLine(message);

message = service.WalletTransfer("8888888888", "0987654321");
Console.WriteLine(message);


Console.ReadLine();
public class TransferService
{
    private static string _fromMobileNo = "1234567890";
    private static string _toMobileNo = "0987654321";
    private static decimal _fromBalance = 10000;
    private static decimal _toBalance = 15000;

    public string WalletTransfer(string fromMobileNo, string toMobileNo, decimal amount = 1000)
    {
        // Console.WriteLine($"From Mobile No: {fromMobileNo}");
        // Console.WriteLine($"To Mobile No: {toMobileNo}");
        // Console.WriteLine($"Amount: {amount}");
        // 
        // if (fromMobileNo == _fromMobileNo && toMobileNo == _toMobileNo)
        // {
        //     _fromBalance -= amount;
        //     _toBalance += amount;
        // 
        // }
        // else if (fromMobileNo == _toMobileNo && toMobileNo == _fromMobileNo)
        // {
        //     _toBalance -= amount;
        //     _fromBalance += amount;


        Account fromAccount = Database.Accounts.Where(x => x.MobileNo == fromMobileNo).FirstOrDefault();
        Account toAccount = Database.Accounts.Where(x => x.MobileNo == toMobileNo).FirstOrDefault();

        fromAccount.Balance -= amount;
        toAccount.Balance += amount;

        Console.WriteLine($"From Mobile No: {fromMobileNo}");
        Console.WriteLine($"To Mobile No: {toMobileNo}");
        Console.WriteLine("================================");


        return "Wallet Transfer Successful";
    }

    public class WalletTransferService : TransferService
    {
        public string WalletTransfer(string fromMobileNo, string toMobileNo, decimal amount)
        {
            return WalletTransfer(fromMobileNo, toMobileNo, amount);
        }

    }

}

public class Account
{
    public Account()
    {
        // Balance = 10000;
    }
    public Account(string mobileNo, decimal balance)
    {
        MobileNo = mobileNo;
        Balance = balance;
    }

    private decimal balance;

    public decimal Balance
    {
        get
        {
            return balance;
        }
        set
        {
            Console.WriteLine(MobileNo + "Old Value: " + balance);
            balance = value;
            Console.WriteLine(MobileNo + "New Value: " + balance);
        }
    }

    public string MobileNo { get; internal set; }
}


public class Database
{
    public static Account[] Accounts = new Account[2]
    {
        new Account()
        {
            MobileNo = "1234567890",
            Balance = 1000
        },
        new Account() {
            MobileNo = "0987654321",
            Balance = 500
        }
    };


}