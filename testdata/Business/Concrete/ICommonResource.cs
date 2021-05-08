namespace testdata.Business.Concrete
{
    public interface ICommonResource<T> where T : class
    {        
        string GetString(string str);
    }
}
