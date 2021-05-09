using NUnit.Framework;
using TeppichsTools.Data;

namespace TeppichsTools.Editor.Tests
{
    public class BlackboardTests
    {
        [Test]
        public void ShouldWriteAndReadValue()
        {
            Setup(out Blackboard blackboard);

            string id    = "TestName";
            string value = "TestValue";

            blackboard.Write(id, value);

            Assert.AreEqual(value, blackboard.Read<string>(id));
        }

        [Test]
        public void ShouldWriteAndReadValuesOfDifferentTypes()
        {
            Setup(out Blackboard blackboard);

            string stringId    = "StringTestId";
            string stringValue = "StringTestValue";

            string intId    = "IntTestName";
            int    intValue = 42;

            blackboard.Write(stringId, stringValue);
            blackboard.Write(intId,    intValue);

            Assert.AreEqual((stringValue, intValue), (blackboard.Read<string>(stringId), blackboard.Read<int>(intId)));
        }

        [Test]
        public void ShouldReturnNullOnWrongID()
        {
            Setup(out Blackboard blackboard);
            
            Assert.IsNull(blackboard.Read<string>("id"));
        }

        private void Setup(out Blackboard blackboard) => blackboard = new Blackboard();
    }
}