using System;
using Xunit;
using Graphs.Classes;

namespace GraphTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddVertex()
        {
            Graph<int> testGraph = new Graph<int>();

            int test = 11;

            var testAdd = testGraph.AddVertex(test);

            Assert.Equal(11, testAdd.Value);
        }
    }
}
