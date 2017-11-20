using System.Linq;
using System.Threading;
using EventStore.Core.Index;
using EventStore.Core.TransactionLog;
using NUnit.Framework;
using EventStore.Core.Index.Hashes;
using System;
using EventStore.Core.TransactionLog.LogRecords;

namespace EventStore.Core.Tests.Index.IndexV4
{
    [TestFixture, Category("LongRunning")]
    public class when_upgrading_index_to_64bit_stream_version : IndexV3.when_upgrading_index_to_64bit_stream_version
    {
        public when_upgrading_index_to_64bit_stream_version()
        {
            _ptableVersion = PTableVersions.IndexV4;
        }
    }
}