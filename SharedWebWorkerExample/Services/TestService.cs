namespace SharedWebWorkerExample.Services
{
    public interface ITestService
    {
        Task<string> Method1(string msg);
    }

    public class TestService : ITestService
    {
        public async Task<string> Method1(string msg)
        {
            msg += $"\nHello from shared worker {DateTime.Now}";
            return msg;
        }
    }
}
