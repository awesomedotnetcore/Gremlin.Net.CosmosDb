﻿using Newtonsoft.Json;

namespace Gremlin.Net.CosmosDb.Structure
{
    /// <summary>
    /// An node with an edge and it's vertex in tree representation.
    /// </summary>
    public class TreeEdgeNode
    {
        /// <summary>
        /// The edge.
        /// </summary>
        [JsonProperty("key")]
        public Edge Edge { get; set; }

        /// <summary>
        /// The vertex the edge leads to (can be both the 'in' and 'out' vertex, depending on the traversal).
        /// </summary>
        [JsonProperty("value")]
        public TreeVertexNode VertexNode { get; set; }

        public override string ToString() => Edge.ToString();
    }
}
