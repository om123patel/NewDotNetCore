namespace DotNetCore.Console
{
    using System;
    using System.Linq;
    using DotNetCore.DataLayer;
    using DotNetCore.Model;
    using Microsoft.EntityFrameworkCore;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //using (DotNetCoreContext db = new DotNetCoreContext())
            //{
            //    Country country = db.Countries.Where(d => d.Id == 1).SingleOrDefault();
            //    country.Name = "Pakistan";
            //    db.Entry(country).State = EntityState.Modified;
            //    try
            //    {
            //        db.SaveChanges();
            //    }
            //    catch (Exception ex)
            //    {

            //        throw;
            //    }
                
            //}
        }
    }
}
