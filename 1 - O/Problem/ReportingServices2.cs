namespace Solid._1___O.Problem;

public class ReportingServices2
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
        else if(type == ReportType.JSON)
        {
            CreateJsonReport(orders);
        }
        else if(type == ReportType.XML)
        {
            CreateXMLReport(orders);
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
    
    private void CreateXMLReport(List<Order> orders)
    {
        //Code to create a XML Report
    }

    private void CreateJsonReport(List<Order> orders)
    {
        //Code to create a JSON Report
    }

}

public class Order
{
    //Generic implementation of Order Class.
}

public enum ReportType
{
    PDF,
    EXCEL,
    JSON,
    XML
}