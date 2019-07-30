using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonGenomix.JsonFile
{
    public class mthfr
    {
        public RootObject JsonData;

        public mthfr(string JsonFile)
        {
            JsonData = JsonConvert.DeserializeObject<RootObject>(JsonFile);

        }
        public class RootObject
        {

            [JsonProperty("your report")]
            public IList<IList<string>> YourReport { get; set; }

            [JsonProperty("your report 1")]
            public IList<IList<string>> YourReport1 { get; set; }

            [JsonProperty("how to read")]
            public IList<IList<string>> HowToRead { get; set; }

            [JsonProperty("table1")]
            public IList<IList<string>> Table1 { get; set; }

            [JsonProperty("table2")]
            public IList<IList<string>> Table2 { get; set; }

            [JsonProperty("disclaimer")]
            public IList<IList<string>> Disclaimer { get; set; }

            [JsonProperty("recos")]
            public IList<IList<string>> Recos { get; set; }

            [JsonProperty("mthfr result")]
            public string MthfrResult { get; set; }

            [JsonProperty("reportname")]
            public string Reportname { get; set; }

            [JsonProperty("table1_capt")]
            public string Table1Capt { get; set; }

            [JsonProperty("table2_capt")]
            public string Table2Capt { get; set; }

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

            [JsonProperty("about us")]
            public string AboutUs { get; set; }

            [JsonProperty("graphical_version")]
            public int GraphicalVersion { get; set; }
        }


    }


}
