namespace ASPNetCoreAngularApp2.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly ASPNetCoreAngularApp2DbContext _context;

        public InitialHostDbBuilder(ASPNetCoreAngularApp2DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
