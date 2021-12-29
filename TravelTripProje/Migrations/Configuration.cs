﻿namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    //Bu sayfa üstmenüden, View/Other Vindows/Package Manager Console sekmelerinden açtık. aşşağıya PM> Enable-Migrations yazarak bu sayfayı elde ettik.
    internal sealed class Configuration : DbMigrationsConfiguration<TravelTripProje.Models.Sinifler.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TravelTripProje.Models.Sinifler.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}