//problems: Violate SOLID Principles 
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
public class Order
{
    public string CustomerName { get; set; }
    public List<Product> Products { get; set; }
    public decimal TotalCost { get; set; }
}

/*----------------------------------------------------------------------------------------------------*/
//Create Product Service
public interface IProductManger
{
    public void AddProduct(List<Product> products, Product product);
}
public class ProductManger: IProductManger
{
    public void AddProduct(List<Product> products,Product product)
    {
        products.Add(product);
    }
}
/*----------------------------------------------------------------------------------------------------*/
//Create Order Service
public interface IOrderManager
{
    public void AddOrder(List<Order> orders,Order order);
    public void PlaceOrder(List<Order> orders, Order order, string PaymentMethod);
}

public class OrderManager : IOrderManager
{
    private readonly IPaymentMethod paymentMethod;
    private readonly ISendConfirmationEmail sendConfirmationEmail;

    //Inject For Needed Services
    public OrderManager(IPaymentMethod paymentMethod, ISendConfirmationEmail sendConfirmationEmail)
    {
       
        this.paymentMethod = paymentMethod;
        this.sendConfirmationEmail = sendConfirmationEmail;
    }
    public void AddOrder(List<Order> orders, Order order)
    {
        orders.Add(order);
    }

    public void PlaceOrder(List<Order> orders,Order order, string PaymentMethod)
    {
        decimal totalCost = 0;
        
        foreach (var productItem in order.Products) 
        {
            totalCost += productItem.Price;
            productItem.Quantity--;
        }

        if(order.Products.Count > 0)
        {
            //Use Payment Service
            if (PaymentMethod == "CreditCard")
                paymentMethod.ProcessPayment(totalCost);

            else if (PaymentMethod == "PayPal")
                paymentMethod.ProcessPayment(totalCost);
        }

        //Use Method
        AddOrder(orders, order);

        //Use SendEmail Service
        sendConfirmationEmail.SendOrderConfirmationEmail(order);
    }
}
/*----------------------------------------------------------------------------------------------------*/
//Create Payment Service
public interface IPaymentMethod
{
    public void ProcessPayment(decimal amount);
}
public class ProcessCreditCardPayment: IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of ${amount}");
    }
}

public class ProcessPayPalPayment: IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of ${amount}");
    }
}
/*----------------------------------------------------------------------------------------------------*/
//Create EmailSender Service 
public interface ISendConfirmationEmail
{
    public void SendOrderConfirmationEmail(Order order);
}

public class SendOrderConfirmationEmail : ISendConfirmationEmail
{
    void ISendConfirmationEmail.SendOrderConfirmationEmail(Order order)
    {
        string message = $"Order confirmation for {order.CustomerName}:\n";
        message += $"Total Cost: ${order.TotalCost}\n";
        message += "Products:\n";
        foreach (Product product in order.Products)
        {
            message += $"- {product.Name} (${product.Price})\n";
        }

        Console.WriteLine(message);
    }
}



/*----------------------------------------------------------------------------------------------------*/
public class ECommerceSystem
{
    private readonly IProductManger productManger;
    private readonly IOrderManager orderManager;

    private List<Product> products = new List<Product>();
    private List<Order> orders = new List<Order>();

    //Inject Two Services
    public ECommerceSystem(IProductManger productManger, IOrderManager orderManager)
    {
        this.productManger = productManger;
        this.orderManager = orderManager;
    }

    public void AddProduct(Product product)
    {
        //use productManger Service
        productManger.AddProduct(products, product);
    }

    public void PlaceOrder(Order order, string PaymentMethod)
    {
        //use orderManager Service
        orderManager.PlaceOrder(orders, order, PaymentMethod);
    }
}
