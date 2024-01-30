class Program
{
    static void Main(string[] args)
    {
        // Setting up the chain
        SupportHandler callCenterExecutive = new CallCenterExecutive();
        SupportHandler supervisor = new Supervisor();
        SupportHandler manager = new Manager();

        callCenterExecutive.SetNextHandler(supervisor);
        supervisor.SetNextHandler(manager);

        // Various requests
        SupportRequest basicRequest = new SupportRequest("I can't log in.", SupportLevel.Basic);
        SupportRequest intermediateRequest = new SupportRequest("My screen is flickering.", SupportLevel.Intermediate);
        SupportRequest advancedRequest = new SupportRequest("Database connection failure.", SupportLevel.Advanced);

        // Handling requests
        callCenterExecutive.HandleRequest(basicRequest);
        callCenterExecutive.HandleRequest(intermediateRequest);
        callCenterExecutive.HandleRequest(advancedRequest);
    }
}
