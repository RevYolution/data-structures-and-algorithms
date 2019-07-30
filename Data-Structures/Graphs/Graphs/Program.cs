using Graphs.Classes;
using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<string> testGraph = new Graph<string>();

            var a = testGraph.AddVertex("Toledo");
            var b = testGraph.AddVertex("FlagStaff");
            var c = testGraph.AddVertex("Seattle");

            testGraph.AddDirectedEdge(a, b, 22);
            testGraph.AddDirectedEdge(b, c, 25);
            testGraph.AddDirectedEdge(c, a, 15555);

            testGraph.Print();
        }
    }
}
