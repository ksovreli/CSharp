using TenthConsoleApp.enums;

namespace TenthConsoleApp.model
{
    internal class Phone : Product
    {
        public Brands Brand { get; set; }
        public uint Memory { get; set; }

        public override void Example()
        {
            Console.WriteLine("this is phone class");
        }
    }
}
