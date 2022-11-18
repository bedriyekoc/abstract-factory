using FactoryBusiness;

namespace CustomFactoryTwo
{
    public class CustomFactoryTwoLogic : IBusinessInterface
    {
        public FactoryType FType => FactoryType.Two;

        public int Run()
        {
            //return something
            return 0;
        }

        public void Start()
        {
            Console.Write("start method is called  by CustomFactoryTwo");
        }

        public void Stop()
        {
            Console.Write("stop method  is called  by CustomFactoryTwo");
        }
    }
}