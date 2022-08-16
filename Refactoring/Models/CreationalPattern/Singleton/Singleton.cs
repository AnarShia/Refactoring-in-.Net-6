namespace Refactoring.Models.Singleton
{
    public sealed class Singleton
    {
        private static Singleton _singleton;
        private Singleton(){}


        public static Singleton getInstance()
        {
            return _singleton ??= new Singleton();
        }
    }
}
