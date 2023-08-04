namespace Solid._1___O.Problem;

internal class Program
{
    public static void Main()
    {
        List<Order> orders = new List<Order>();

        ReportingServices services = new ReportingServices();
        services.GenerateReport(orders, ReportType.PDF);
    }
}