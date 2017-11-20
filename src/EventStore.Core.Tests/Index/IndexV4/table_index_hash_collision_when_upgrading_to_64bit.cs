using EventStore.Core.Index;
using NUnit.Framework;

namespace EventStore.Core.Tests.Index.IndexV4
{
    [TestFixture, Category("LongRunning")]
    public class table_index_hash_collision_when_upgrading_to_64bit : IndexV2.table_index_hash_collision_when_upgrading_to_64bit
    {
        public table_index_hash_collision_when_upgrading_to_64bit()
        {
            _ptableVersion = PTableVersions.IndexV4;
        }
    }
}