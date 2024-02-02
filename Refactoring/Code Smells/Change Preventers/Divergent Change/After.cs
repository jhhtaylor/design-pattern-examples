public class ReportGenerator
{
    public void GenerateReport(string reportData)
    {
        // Logic to generate the report
        Console.WriteLine("Report generated");
    }
}

public class ReportDatabaseManager
{
    public void SaveReport(string reportData)
    {
        // Logic to save report to a database
        Console.WriteLine("Report saved to database");
    }

    public string LoadReport(int reportId)
    {
        // Logic to load a report from a database
        return "Report data";
    }
}

class Program
{
    static void Main(string[] args)
    {
        string reportData = "Some report data";
        ReportGenerator generator = new ReportGenerator();
        generator.GenerateReport(reportData);

        ReportDatabaseManager dbManager = new ReportDatabaseManager();
        dbManager.SaveReport(reportData);
        string loadedReport = dbManager.LoadReport(1);
    }
}
