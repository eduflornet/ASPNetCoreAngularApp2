namespace ASPNetCoreAngularApp2.Helpers
{
    public interface ITypeHelperService
    {
        bool TypeHasProperties<T>(string fields);
    }
}
