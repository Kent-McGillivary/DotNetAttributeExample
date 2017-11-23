namespace DotNetSamples.Models {
    public class SampleModel {

        public GeometryModel Geometry {get;set;} = new GeometryModel();

        public PropertyModel Properties {get;set;} = new PropertyModel();

        public string Item {get;set;}
    }
}