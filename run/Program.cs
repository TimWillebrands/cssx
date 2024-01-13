using Cssx;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Cssx.Cssx.Parse("""
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8">
    <title>{"Cssx"}</title>
  </head>
  <body>
    {"Hello my boi"}
  </body>
</html>
"""));

app.Run();
