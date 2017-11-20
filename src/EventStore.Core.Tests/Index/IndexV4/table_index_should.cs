using EventStore.Core.Index;
using NUnit.Framework;

namespace EventStore.Core.Tests.Index.IndexV4
{
    [TestFixture]
    public class table_index_should : IndexV1.table_index_should
    {
        public table_index_should()
        {
            _ptableVersion = PTableVersions.IndexV4;
        }
    }
}