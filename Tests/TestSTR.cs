using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using SLIDDES.String;

namespace SLIDDES.Testing
{
    public class TestSTR
    {
        [Test]
        public void GetNthCharIndex()
        {
            Assert.AreEqual("AGaGtGT".GetNthCharIndex('t', 2), 6);
        }

        [Test]
        public void GetUntilOrEmpty()
        {
            Assert.AreEqual("aaataa".GetUntilOrEmpty("t"), "aaa");
        }

        [Test]
        public void SubstringBetween()
        {
            Assert.AreEqual("value1value2value3".SubstringBetween("value1", "value3"), "value2");
        }
    }
}