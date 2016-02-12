using TechTalk.SpecFlow;

namespace GCE.Tests.Base
{
    internal abstract class BaseContext
    {
        public Table Table { get; set; }
        public object Result { get; set; }
    }
}