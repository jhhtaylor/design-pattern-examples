public class ReportGenerator
{
    public void GenerateReport(List<Data> reportData)
    {
        if (!ValidateData(reportData))
        {
            Console.WriteLine("No data to generate the report.");
            return;
        }

        var processedData = ProcessData(reportData);
        var report = BuildReport(processedData);
        PrintReport(report);
    }

    private bool ValidateData(List<Data> reportData)
    {
        return reportData != null && reportData.Any();
    }

    private List<ProcessedData> ProcessData(List<Data> reportData)
    {
        return reportData.Select(data => ProcessSingleData(data)).ToList();
    }

    private StringBuilder BuildReport(List<ProcessedData> processedData)
    {
        var report = new StringBuilder();
        foreach (var data in processedData)
        {
            report.AppendLine($"Data Item: {data.ToString()}");
        }
        return report;
    }

    private void PrintReport(StringBuilder report)
    {
        Console.WriteLine("Generated Report:");
        Console.WriteLine(report.ToString());
    }

    private ProcessedData ProcessSingleData(Data data)
    {
        // Processing logic
        return new ProcessedData();
    }
}

public class Data { }
public class ProcessedData { }
