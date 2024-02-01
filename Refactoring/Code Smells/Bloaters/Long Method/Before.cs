public class ReportGenerator
{
    public void GenerateReport(List<Data> reportData)
    {
        // Step 1: Validate data
        if (reportData == null || !reportData.Any())
        {
            Console.WriteLine("No data to generate the report.");
            return;
        }

        // Step 2: Process data
        var processedData = new List<ProcessedData>();
        foreach (var data in reportData)
        {
            processedData.Add(ProcessData(data));
        }

        // Step 3: Generate report
        var report = new StringBuilder();
        foreach (var data in processedData)
        {
            report.AppendLine($"Data Item: {data.ToString()}");
        }

        // Step 4: Print report
        Console.WriteLine("Generated Report:");
        Console.WriteLine(report.ToString());
    }

    private ProcessedData ProcessData(Data data)
    {
        // Processing logic
        return new ProcessedData();
    }
}

public class Data { }
public class ProcessedData { }
