namespace Solid._0___S.Problem;

public class OrderService
{
    /*
     * El problema que viene a resolver este principio es el siguiente:
     * El de las superclases con muchas responsabilidades. Esto genera un código poco legible y mantenible, ya que al tener tantas responsabilidades, para cua
     */
    public void SaveOrder(Order order)
    {
        try
        {
            this.InsertOrder(order);
            var invoice = this.CreateInvoice(order);
            this.EmailInvoice(invoice);
            File.WriteAllText(@"C:\InfoLog.txt","The order has been complete");
        }
        catch (Exception e)
        {
            File.WriteAllText(@"C:\ErrorLog.txt",e.Message);

        }
    }
    
    private void InsertOrder(Order order)
    {
        //Code to Insert the order on the database.
        throw new NotImplementedException();
    }
    
    private object CreateInvoice(Order order)
    {
        //Code to Create the Invoice.
        throw new NotImplementedException();
    }
    
    private void EmailInvoice(object invoice)
    {
        //Code to send email Invoice
        throw new NotImplementedException();
    }

}

public class Order
{
}