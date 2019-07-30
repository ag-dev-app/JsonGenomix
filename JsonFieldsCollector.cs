using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonGenomix
{
    public class JsonFieldsCollector
    {
        public readonly Dictionary<string, JValue> fields;
        private List<string> fieldsKeys;


        public JsonFieldsCollector(JToken token)
        {
            fields = new Dictionary<string, JValue>();
            fieldsKeys = new List<string>();
            CollectFields(token);
        }

        private void CollectFields(JToken jToken)
        {
            switch (jToken.Type)
            {
                case JTokenType.Object:
                    foreach (var child in jToken.Children<JProperty>())
                        CollectFields(child);
                    break;
                case JTokenType.Array:
                    foreach (var child in jToken.Children())
                        CollectFields(child);
                    break;
                case JTokenType.Property:
                    CollectFields(((JProperty)jToken).Value);
                    break;
                default:
                    fields.Add(jToken.Path, (JValue)jToken);
                    break;
            }
        }

        public IEnumerable<KeyValuePair<string, JValue>> GetAllFields() => fields;

        public static string AllJsonFieldsDisplay(string JsonString)
        {
            var json = JToken.Parse(JsonString);
            var fieldsCollector = new JsonFieldsCollector(json);
            var fields = fieldsCollector.GetAllFields();
            string txt = "";
            foreach (var field in fields)
                txt+=($"{field.Key}: '{field.Value}'\r\n");
            return txt;
        }

        public void SetFieldsKeys(string JsonString)
        {
            var json = JToken.Parse(JsonString);
            var fieldsCollector = new JsonFieldsCollector(json);
            var fields = fieldsCollector.GetAllFields();


            foreach (var field in fields)
                fieldsKeys.Add(field.Key);
        }

        public List<string> GetFieldsKeys()
        {
            return fieldsKeys;
        }


        public string DisplayFieldsKeys()
        {
            string txt = "";
            foreach (string key in fieldsKeys)
            {
                txt += key + "\n";
            }
            return txt;
        }

        public string DisplayDatas(string key)
        {
            return fields[key].ToString();
        }

        public string ShowDictionnary()
        {
            string txt = "";
            foreach (KeyValuePair<string, JValue> field in fields)
            {
                txt += "Key = " + $"{ field.Key}" + "Value = " + $"{field.Value}" +"\n";
            }
            return txt;
        }

}

}
