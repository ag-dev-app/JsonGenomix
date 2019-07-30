using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JsonGenomix.JsonFile
{
    public class all
    {
        public RootObject JsonData;

        public all(string JsonFile)
        {
            JsonData = JsonConvert.DeserializeObject<RootObject>(JsonFile);

        }
        
        public partial class Table1
        {
            [JsonProperty("trait")]
            public string Trait { get; set; }

            [JsonProperty("summary")]
            public string Summary { get; set; }

            [JsonProperty("comb")]
            public string Comb { get; set; }

            public override string ToString()
            {
                return Trait + "\r\n\r\n" +
                       Summary + "\r\n\r\n" +
                       Comb + "\r\n\r\n\r\n";
            }
        }

        public partial class Table2
        {

            [JsonProperty("trait")]
            public string Trait { get; set; }

            [JsonProperty("genes")]
            public string Genes { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("outcome")]
            public string Outcome { get; set; }

            [JsonProperty("recommendation")]
            public string Recommendation { get; set; }

            public override string ToString()
            {
                return Trait + "\r\n\r\n" +
                       Genes + "\r\n\r\n" +
                       Description + "\r\n\r\n" +
                       Outcome + "\r\n\r\n" +
                       Recommendation + "\r\n\r\n\r\n";
            }
        }

        public partial class RootObject
        {

            [JsonProperty("your report")]
            public List<List<string>> YourReport { get; set; }

            [JsonProperty("how to read")]
            public List<List<string>> HowToRead { get; set; }

            [JsonProperty("table1")]
            public List<Table1> Table1 { get; set; }

            [JsonProperty("table2")]
            public List<Table2> Table2 { get; set; }

            [JsonProperty("table3")]
            public string Table3 { get; set; }

            [JsonProperty("table4")]
            public string Table4 { get; set; }

            [JsonProperty("table5")]
            public string Table5 { get; set; }

            [JsonProperty("disclaimer")]
            public List<List<string>> Disclaimer { get; set; }

            [JsonProperty("about us")]
            public string AboutUs { get; set; }

            [JsonProperty("graphical_version")]
            public int GraphicalVersion { get; set; }

            [JsonProperty("CFP")]
            public string CFP { get; set; }

            [JsonProperty("ES_pie")]
            public string ESPie { get; set; }

            [JsonProperty("PFC")]
            public string PFC { get; set; }

            [JsonProperty("EPF")]
            public string EPF { get; set; }

            [JsonProperty("reportname")]
            public string Reportname { get; set; }

            [JsonProperty("Name")]
            public string Name { get; set; }

            [JsonProperty("ID")]
            public string ID { get; set; }

            [JsonProperty("uploaded_file")]
            public string UploadedFile { get; set; }

            [JsonProperty("partner")]
            public string Partner { get; set; }

            [JsonProperty("package")]
            public string Package { get; set; }
        }
    }
}
