using System; using Microsoft.AspNetCore.Identity; foreach(var p in typeof(IdentityUser).GetProperties()) { Console.WriteLine(p.PropertyType.Name + " " + p.Name); }
