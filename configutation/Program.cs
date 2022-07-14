using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

using IHost host = Host.CreateDefaultBuilder(args).Build();

// Ask the service provider for the configuration abstraction.
IConfiguration config = host.Services.GetRequiredService<IConfiguration>();

// Get values from the config given their key and their target type.
string ipOne = config["IPAddressRange:0"];
string ipTwo = config["IPAddressRange:1"];
string ipThree = config["IPAddressRange:2"];
string versionOne = config["SupportedVersions:v1"];
string versionThree = config["SupportedVersions:v3"];

// Write the values to the console.
Console.WriteLine($"IPAddressRange:0 = {ipOne}");
Console.WriteLine($"IPAddressRange:1 = {ipTwo}");
Console.WriteLine($"IPAddressRange:2 = {ipThree}");
Console.WriteLine($"SupportedVersions:v1 = {versionOne}");
Console.WriteLine($"SupportedVersions:v3 = {versionThree}");

// Application code which might rely on the config could start here.

await host.RunAsync();