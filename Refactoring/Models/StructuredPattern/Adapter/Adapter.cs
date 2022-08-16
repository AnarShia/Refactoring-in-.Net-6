namespace Refactoring.Models.StructuredPattern.Adapter
{
    public class AdapterClass
    {
        public interface ITarget
        {
            void Request();
        }
        class Adaptee
        {
            public void SpecificRequest()
            {
                Console.WriteLine("SpecificRequest");
            }
        }
        class Adapter : ITarget
        {
            private readonly Adaptee _adaptee;
            public Adapter(Adaptee adaptee)
            {
                _adaptee = adaptee;
            }
            public void Request()
            {
                _adaptee.SpecificRequest();
            }
        }
        public void Test()
        {
            var adapter = new Adapter(new Adaptee());
            adapter.Request();
        }


        // Takes another object method and makes it compatible with the current object.//

    }
}
