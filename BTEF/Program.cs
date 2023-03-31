using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using BTEF;
using Microsoft.EntityFrameworkCore;

namespace BTEF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new SchoolContext();
            DbInitializer.Initialize(db);
        }
    }
}