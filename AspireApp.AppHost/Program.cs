var builder = DistributedApplication.CreateBuilder(args);

var redis = builder.AddRedisContainer("cache");

var apiservice = builder.AddProject<Projects.AspireApp_ApiService>("apiservice");

builder.AddProject<Projects.AspireApp_Web>("webfrontend")
    .WithReference(redis)
    .WithReference(apiservice);

builder.Build().Run();
