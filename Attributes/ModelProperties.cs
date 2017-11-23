using System;
using DotNetSamples;

namespace DotNetSamples.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ModelProperties:Attribute {
        
        public String DbName {get; private set;}
        public DataType DbFieldType {get;private set;}

        public ModelProperties(String dbName, DataType type) {
            this.DbName = dbName;
            this.DbFieldType = type;
        }

        
    }
    
}