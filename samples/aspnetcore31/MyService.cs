namespace AutoMapperProfileWithDI
{
    public interface IMyService
    {
        string DoSomething();
    }

    public class MyService : IMyService
    {
        public string DoSomething()
        {
            return "MyService did something!!!";
        }
    }
}
