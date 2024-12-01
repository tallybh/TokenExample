using Newtonsoft.Json;

namespace TokenExample
{
    public interface IMyToken
    {
        public string Company { get; set; }
        public string Email { get; set; }
    }

    public class MyToken:IMyToken
    {
        public string Company { get; set; }

      
        public string Email { get; set; }
    }
}
