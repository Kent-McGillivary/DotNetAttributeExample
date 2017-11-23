using DotNetSamples.Attributes;

namespace DotNetSamples.Models {

    [Neo4jClass]
    public class GeometryModel {

        [ModelProperties("location",DataType.String)]
        public string Location {get;set;}
        
    }
}