using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonGenomix
{
    public class txt_report
    {
        public RootObject JsonData;

        public txt_report(string JsonFile)
        {
            JsonData = JsonConvert.DeserializeObject<RootObject>(JsonFile);

        }
        public class Table1
        {

            [JsonProperty("gene")]
            public string Gene { get; set; }

            [JsonProperty("diplo")]
            public string Diplo { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            public override string ToString()
            {
                return Gene + "\r\n\r\n" +
                       Diplo + "\r\n\r\n" +
                       Status + "\r\n\r\n\r\n";
            }
        }

        public class Table2
        {

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("genes")]
            public string Genes { get; set; }

            [JsonProperty("outcome")]
            public string Outcome { get; set; }

            [JsonProperty("recommendation")]
            public string Recommendation { get; set; }

            [JsonProperty("trait")]
            public string Trait { get; set; }

            [JsonProperty("area")]
            public string Area { get; set; }

            [JsonProperty("level")]
            public object Level { get; set; }
        }

        public class RootObject
        {

            [JsonProperty("your report")]
            public IList<IList<string>> YourReport { get; set; }

            [JsonProperty("how to read")]
            public IList<IList<string>> HowToRead { get; set; }

            [JsonProperty("table1")]
            public IList<Table1> Table1 { get; set; }

            [JsonProperty("table2")]
            public IList<Table2> Table2 { get; set; }

            [JsonProperty("disclaimer")]
            public IList<IList<string>> Disclaimer { get; set; }

            [JsonProperty("disclaimer_1")]
            public IList<IList<string>> Disclaimer1 { get; set; }

            [JsonProperty("reportname")]
            public string Reportname { get; set; }

            [JsonProperty("Name")]
            public string Name { get; set; }

            [JsonProperty("ID")]
            public string ID { get; set; }

            [JsonProperty("uploaded_file")]
            public string UploadedFile { get; set; }

            [JsonProperty("package")]
            public string Package { get; set; }

            [JsonProperty("partner")]
            public string Partner { get; set; }
        }


    }
}
