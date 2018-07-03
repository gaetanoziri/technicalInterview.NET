using Microsoft.VisualStudio.TestTools.UnitTesting;
using technicalInterview.algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technicalInterview.algorithm.Tests
{
    [TestClass()]
    public class MorseCodeTests
    {
        [TestMethod()]
        public void DecodeTest()
        {
            Assert.AreEqual(MorseCode.Decode(".-"), "A");
            Assert.AreEqual(MorseCode.Decode("."), "E");
            Assert.AreEqual(MorseCode.Decode(".."), "I");
            Assert.AreEqual(MorseCode.Decode(". ."), "EE");
            Assert.AreEqual(MorseCode.Decode(".   ."), "E E");
            Assert.AreEqual(MorseCode.Decode("... --- ..."), "SOS");
            Assert.AreEqual(MorseCode.Decode("...   ---   ..."), "S O S");
            Assert.AreEqual(MorseCode.Decode(".... . -.--   .--- ..- -.. ."), "HEY JUDE");
            Assert.AreEqual(MorseCode.Decode(" . "), "E");
            Assert.AreEqual(MorseCode.Decode("   .   . "), "E E");
            Assert.AreEqual(MorseCode.Decode("      ...---... -.-.--   - .... .   --.- ..- .. -.-. -.-   -... .-. --- .-- -.   ..-. --- -..-   .--- ..- -- .--. ...   --- ...- . .-.   - .... .   .-.. .- --.. -.--   -.. --- --. .-.-.-  "), "SOS! THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG.");
        }
    }
}