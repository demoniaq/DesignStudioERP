﻿namespace DesignStudioErp.Persistence
{
    internal class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
