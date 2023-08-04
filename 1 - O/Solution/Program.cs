using Solid._1___O.Problem;

namespace Solid._1___O.Solution;

internal class Program
{
    public static void Main()
    {
        List<Order> orders = List<Order>();

        ReportingService service = new ReportingService(new ReportGeneratorXML());
        service.GenerateReport(orders);
    }
}