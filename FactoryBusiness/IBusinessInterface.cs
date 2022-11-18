namespace FactoryBusiness
{
    public interface IBusinessInterface
    {
        FactoryType  FType { get; }

        void Start();
        int Run();
        void Stop();
    
    }
}