using FactoryBusiness;

namespace CustomFactoryOne
{
    public class CustomFactoryOneLogic : IBusinessInterface
    {
        public FactoryType FType => FactoryType.One;

        public int Run()
        {
            //return something
            return 0;
        }

        public void Start()
        {
            Console.Write("start method is called  by CustomFactoryOne ");

        }

        public void Stop()
        {
            Console.Write("stop method  is called  by CustomFactoryOne");
        }
    }
}