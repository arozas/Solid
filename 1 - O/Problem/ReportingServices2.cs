namespace Solid._1___O.Problem;

public class ReportingServices
{
    public void GenerateReport(List<Order> orders, ReportType type)
    {
        //Generic implementation to create a report.
        
        //Specific conversion depending on type
        if (type == ReportType.PDF)
        {
            CreatePDFReport(orders);
        }
        else if(type == ReportType.EXCEL)
        {
            CreateExcelReport(orders);
        }
    }

    private void CreateExcelReport(List<Order> orders)
    {
        //Code to create an Excel Report
    }

    private void CreatePDFReport(List<Order> orders)
    {
        //Code to create a PDF Report
    }
}

public class Order
{
    //Generic implementation of Order Class.
}

public enum ReportType
{
    PDF,
    EXCEL
}