using System;
using System.Diagnostics;
using System.Reflection;
using DotNetSamples.Models;

namespace DotNetSamples.Attributes {
    public class ProcessAttributes {
        public void Run() {

            SampleModel model = new SampleModel();
            model.Geometry.Location = "{x:1.2,y:2.0}";
            model.Properties.Color = "#FFAABB";
            model.Properties.Id = "{AB-12-3}";
            model.Properties.IsSpecial = true;
            model.Properties.Name = "Test1";

            this.ProcessItem(model);


          
        }

        public void ProcessItem(Object obj) {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();
            foreach(var propItem in properties) {

                if(ClassHasModelProperties(propItem,obj, out object propValue)) {
                    ProcessModelPropertyItems(propValue);
                }
           
                
            }
                
        }
        

        public void ProcessModelPropertyItems(Object propertyValue) {
            PropertyInfo[] properties = propertyValue.GetType().GetProperties();
              foreach(PropertyInfo propItem in properties) {
                    ModelProperties modelAttr = propItem.GetCustomAttribute<ModelProperties>();
                    if (modelAttr != null)
                    {
                        string propName = propItem.Name;
                        object propValue = propItem.GetValue(propertyValue);
                        string dbName = modelAttr.DbName;
                        DataType dbType = modelAttr.DbFieldType;
                        Debug.WriteLine($" Property: {propName} DbName: {dbName} DbType: {dbType} Value: {propValue}");
                    }
              }


        }

        public bool ClassHasModelProperties(PropertyInfo prop, Object obj,out Object propValue) {
             propValue = null;
            var valueItem = prop.GetValue(obj);
            if(valueItem != null) {
                var attributes = valueItem.GetType().GetCustomAttribute<Neo4jClass>();
                if(attributes != null) {
                    propValue = valueItem;
                    return true;
                }
              
                return false;
            }
            else {
                return false;
            }

        }
    }

}