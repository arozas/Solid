using Solid._1___O.Problem;

namespace Solid._1___O.Solution;

public class ReportingService
{
    private readonly IReportGenerator _reportGenerator;

    public ReportingService(IReportGenerator reportGenerator)
    {
        _reportGenerator = reportGenerator;
    }

    public void GenerateReport(List<Order> orders)
    {
        _reportGenerator.CreateReport(orders);
    }
}