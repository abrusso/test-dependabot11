// See https://aka.ms/new-console-template for more information
using Serilog;
Log.Logger = new LoggerConfiguration()
                            // add console as logging target
                            .WriteTo.Console()
                            // set default minimum level
                            .MinimumLevel.Debug()
                            .CreateLogger();
Log.Information( "Test Log" );