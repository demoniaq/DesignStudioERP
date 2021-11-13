namespace DesignStudioErp.Persistence.Context
{
    internal class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
