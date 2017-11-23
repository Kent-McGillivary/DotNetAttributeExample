using System;
using DotNetSamples.Attributes;

namespace DotNetSamples.Models {
    [Neo4jClass]
    public class PropertyModel {
        
        [ModelProperties("name", DataType.String)]
        public string Name {get;set;}
        public string Id {get;set;}

        [ModelProperties("color", DataType.String)]
        public string Color {get;set;}

        [ModelProperties("isSpecial", DataType.Boolean)]
        public bool IsSpecial {get;set;}
    }
}