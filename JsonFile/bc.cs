using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonGenomix.JsonFile
{
    public class bc
    {
        public RootObject JsonData;

        public bc(string JsonFile)
        {
            JsonData = JsonConvert.DeserializeObject<RootObject>(JsonFile);

        }

        public class Table1
        {

            [JsonProperty("FDA approved BRCA Markers")]
            public IList<IList<object>> FDAApprovedBRCAMarkers { get; set; }

            [JsonProperty("BRCA1 Risk Markers")]
            public IList<IList<object>> BRCA1RiskMarkers { get; set; }

            [JsonProperty("BRCA2 Risk Markers")]
            public IList<IList<object>> BRCA2RiskMarkers { get; set; }

            [JsonProperty("Breast Cancer risk")]
            public IList<IList<object>> BreastCancerRisk { get; set; }

            [JsonProperty("Breast and Ovarian Cancer Risk")]
            public IList<IList<object>> BreastAndOvarianCancerRisk { get; set; }

            [JsonProperty("Breast and Other Cancer Risk")]
            public IList<IList<object>> BreastAndOtherCancerRisk { get; set; }

            [JsonProperty("Early Onset Breast Cancer Risk")]
            public IList<IList<object>> EarlyOnsetBreastCancerRisk { get; set; }

            [JsonProperty("Estrogen Receptor Negative Cancer Risk")]
            public IList<IList<object>> EstrogenReceptorNegativeCancerRisk { get; set; }

            [JsonProperty("Estrogen Receptor Positive Cancer Risk")]
            public IList<IList<object>> EstrogenReceptorPositiveCancerRisk { get; set; }

            [JsonProperty("Breast Cancer risk for men")]
            public IList<IList<object>> BreastCancerRiskForMen { get; set; }

            [JsonProperty("Breast cancer prognosis")]
            public IList<IList<object>> BreastCancerPrognosis { get; set; }

            [JsonProperty("Breast Feeding Duration and Breast Cancer Risk")]
            public IList<IList<object>> BreastFeedingDurationAndBreastCancerRisk { get; set; }

            [JsonProperty("Breast Size and Breast Cancer Risk")]
            public IList<IList<object>> BreastSizeAndBreastCancerRisk { get; set; }

            [JsonProperty("Estradiol Plasma Levels and Breast Cancer Risk")]
            public IList<IList<object>> EstradiolPlasmaLevelsAndBreastCancerRisk { get; set; }

            [JsonProperty("Menopausal Hormone Therapy Interaction with Breast Cancer Risk")]
            public IList<IList<object>> MenopausalHormoneTherapyInteractionWithBreastCancerRisk { get; set; }

            [JsonProperty("Hair Loss due to chemotherapy in breast cancer")]
            public IList<IList<object>> HairLossDueToChemotherapyInBreastCancer { get; set; }

            [JsonProperty("Hypertension due to chemotherapy in breast cancer (bevacizumab)")]
            public IList<IList<object>> HypertensionDueToChemotherapyInBreastCancerBevacizumab { get; set; }

        }

        public class RootObject
        {

            [JsonProperty("your report")]
            public IList<IList<string>> YourReport { get; set; }

            [JsonProperty("how to read")]
            public IList<IList<string>> HowToRead { get; set; }

            [JsonProperty("table1")]
            public Table1 Table1 { get; set; }

            [JsonProperty("table2")]
            public IList<IList<string>> Table2 { get; set; }

            [JsonProperty("disclaimer")]
            public IList<IList<string>> Disclaimer { get; set; }

            [JsonProperty("Name")]
            public string Name { get; set; }

            [JsonProperty("ID")]
            public string ID { get; set; }

            [JsonProperty("uploaded_file")]
            public string UploadedFile { get; set; }

            [JsonProperty("reportname")]
            public string Reportname { get; set; }

            [JsonProperty("package")]
            public string Package { get; set; }

            [JsonProperty("partner")]
            public string Partner { get; set; }

            [JsonProperty("graphical_version")]
            public int GraphicalVersion { get; set; }
        }
    }
}
