namespace newStart;

public class BankAccount
{
    private static int count = 0;
    public Guid accountId {get; set;}
    public string owner {get; set;}
    public double balance {get; private set;}

    public BankAccount(string OwnerName){
        accountId = Guid.NewGuid();
        owner = OwnerName;
        balance = 0;
        count++;
    }

    public void Deposit(int value){

    }
    public void Withdraw(int value){

    }
    public void GetBalance(){

    }
    public string GetAccountInfo(){
    throw new NotImplementedException();
    }
    private bool IsValidAmount(){
        return true;
    }
    static int GetTotalCounts(){
        return count;
    }
    static Guid GenerateAccountID(){
        return Guid.NewGuid();
    }
}
