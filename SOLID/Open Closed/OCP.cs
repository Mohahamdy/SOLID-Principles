////Problems: if I need to add a new payment mehtod so i need to modify in two places in Enum PaymentType and in class PaymentProcessor as adding a new case in switch
//public class PaymentProcessor
//{
//    public void ProcessPayment(PaymentType type, double amount)
//    {
//        switch (type)
//        {
//            case PaymentType.CreditCard:
//                //Process credit card payment
//                break;
//            case PaymentType.PayPal:
//                //Process PayPal payment 
//                break;
//            case PaymentType.BankTransfer:
//                //Process bank transfer payment
//                break;
//            //Add more cases for other payment types
//        }
//    }
//}
//public enum PaymentType { CreditCard, PayPal, BankTransfer }


/* Solution */

//To apply OCP i need to make a interface Called IpaymentMethod Having the method of calcualting
public interface IpaymentMethod
{
    public void ProcessPayment(double amount);
}

// Separate Ways of payment and implement the IpaymentMethod interface
public class CreditCardPayment : IpaymentMethod
{
    public void ProcessPayment(double amount)
    {
        //Process credit card payment
    }
}

public class PayPalPayment : IpaymentMethod
{
    public void ProcessPayment(double amount)
    {
        //Process PayPal paymentt
    }
}

public class BankTransferPayment : IpaymentMethod
{
    public void ProcessPayment(double amount)
    {
        //Process bank transfer payment
    }
}

//Now If i need To extend or add new method, just create class and implement The interface