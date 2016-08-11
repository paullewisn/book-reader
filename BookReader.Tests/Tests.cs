using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BookReader.Tests
{
    [TestFixture]
    public class Tests
    {
        private Reader _reader;

        [SetUp]
        public void SetUp()
        {
            _reader = new Reader();
        }

        [TestCaseSource(nameof(TestCases))]
        public void CountAllWords(string input, int knownCount)
        {
            Assert.That(_reader.CountWords(input, string.Empty), Is.EqualTo(knownCount));
        }

        public object[] TestCases =
        {
            new object[]
            {
                "In 2003, for the first time since the Second World War, the United Kingdom took part in an opposed invasion and full‑scale occupation of a sovereign State – Iraq.Cabinet decided on 17 March to join the US‑led invasion of Iraq, assuming there was no last‑minute capitulation by Saddam Hussein.That decision was ratified by Parliament the next day and implemented the night after that. ",
                64
            }
        };
    }
}