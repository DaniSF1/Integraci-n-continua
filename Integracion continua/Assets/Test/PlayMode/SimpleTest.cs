using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTest : MonoBehaviour
{
    [Test]
    public void SimpleTestSimplePasses()
    {
        Assert.AreEqual(2 + 2, 4);
    }
}
