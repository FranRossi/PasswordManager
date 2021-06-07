using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio1_DA1.Domain;
using Obligatorio1_DA1.Utilities;
using Repository;
using System;
using System.Collections.Generic;

namespace UnitTestObligatorio1
{

    [TestClass]
    public class UnitTestBasicHash : UnitTestHash
    {
        protected override IHash GetHash()
        {
            BasicHash basicHash = new BasicHash();
            return basicHash;
        }
    }
}
