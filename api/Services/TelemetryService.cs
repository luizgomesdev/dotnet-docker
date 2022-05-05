using System.Diagnostics;

using OpenTelemetry;
using OpenTelemetry.Trace;
using OpenTelemetry.Resources;
using API.Interfaces;


namespace API.Services
{


    public class TelemetryService : ITelemetryService
    {
        private static readonly string serviceName = "MyCompany.MyProduct.MyService";
        private static readonly string serviceVersion = "1.0.0";
        public static ActivitySource? activitySource;

        public TelemetryService()
        {
            using var tracerProvider = Sdk.CreateTracerProviderBuilder()
                        .AddSource(serviceName)
                        .SetResourceBuilder(
                            ResourceBuilder.CreateDefault()
                            .AddService(
                                    serviceName: serviceName,
                                    serviceVersion: serviceVersion
                                )
                            )
                        .AddConsoleExporter()
                        .Build();

            activitySource = new ActivitySource(serviceName);
        }


        public void Execute(string activityTitle)
        {
            using var activity = activitySource?.StartActivity(activityTitle);
            activity?.SetTag("foo", 1);
            activity?.SetTag("bar", "Hello, World!");
            activity?.SetTag("baz", new int[] { 1, 2, 3 });

        }

    }


}