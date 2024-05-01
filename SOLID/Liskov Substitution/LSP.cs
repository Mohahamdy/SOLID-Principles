////Problems: The withdraw Method isn't acting in the subclass as in the base class and it will make a change in the base class
//public class Account
//{
//    public decimal Balance { get; protected set; }

//    public virtual void Deposit(decimal amount)
//    {
//        Balance += amount; 
//    }

//    public virtual void Withdraw(decimal amount)
//    {
//        if (Balance >= amount)
//        {
//            Balance -= amount;
//        }
//        else
//        { 
//            throw new InvalidOperationException("Insufficient balance."); }
//        }
//}

//public class SavingsAccount : Account
//{
//    public decimal InterestRate { get; set; }

//    public override void Withdraw(decimal amount)
//    {
//        //Impose a withdrawal fee
//        amount += 5.0m;
//        base.Withdraw(amount);
//    }
//}


/* Solution */
//create a private field called _amount to make logic on it then call the withdraw from parent 

public abstract class AccountBase
{
    public abstract void Deposit(decimal amount);


    public abstract void Withdraw(decimal amount);
   
}

public class Account :AccountBase
{
    public decimal Balance { get; protected set; }

    public override void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public override void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        else
        {
            throw new InvalidOperationException("Insufficient balance.");
        }
    }
}

public class SavingsAccount : AccountBase
{
    public decimal InterestRate { get; set; }

    private decimal _amount {  get; set; }

    public override void Deposit(decimal amount)
    {
        throw new NotImplementedException();
    }

    public override void Withdraw(decimal amount)
    {
        //Impose a withdrawal fee
        _amount = amount + 5.0m;
    }
}



