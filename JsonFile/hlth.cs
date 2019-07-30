using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonGenomix.JsonFile
{
    public class hlth
    {
        public RootObject JsonData;

        public hlth(string JsonFile)
        {
            JsonData = JsonConvert.DeserializeObject<RootObject>(JsonFile);

        }
    }

    public class Table1
    {

        [JsonProperty("Obesity")]
        public IList<IList<object>> Obesity { get; set; }

        [JsonProperty("Type 2 Diabetes")]
        public IList<IList<object>> Type2Diabetes { get; set; }

        [JsonProperty("Heart Disease")]
        public IList<IList<object>> HeartDisease { get; set; }

        [JsonProperty("Hypertension")]
        public IList<IList<object>> Hypertension { get; set; }

        [JsonProperty("Stroke")]
        public IList<IList<object>> Stroke { get; set; }

        [JsonProperty("Thrombosis")]
        public IList<IList<object>> Thrombosis { get; set; }

        [JsonProperty("Atrial Fibrillation")]
        public IList<IList<object>> AtrialFibrillation { get; set; }

        [JsonProperty("Cardiomyopathy")]
        public IList<IList<object>> Cardiomyopathy { get; set; }

        [JsonProperty("Hypertriglyceridemia")]
        public IList<IList<object>> Hypertriglyceridemia { get; set; }

        [JsonProperty("Familial Hypercholesterolemia")]
        public IList<IList<object>> FamilialHypercholesterolemia { get; set; }

        [JsonProperty("Non-Alcoholic Fatty Liver Disease")]
        public IList<IList<object>> NonAlcoholicFattyLiverDisease { get; set; }

        [JsonProperty("Hypothyroidism")]
        public IList<IList<object>> Hypothyroidism { get; set; }

        [JsonProperty("Migraine")]
        public IList<IList<object>> Migraine { get; set; }

        [JsonProperty("Osteoarthritis")]
        public IList<IList<object>> Osteoarthritis { get; set; }

        [JsonProperty("Osteoporosis")]
        public IList<IList<object>> Osteoporosis { get; set; }

        [JsonProperty("Bone Mineral Density")]
        public IList<IList<object>> BoneMineralDensity { get; set; }

        [JsonProperty("Gallstone Disease")]
        public IList<IList<object>> GallstoneDisease { get; set; }

        [JsonProperty("Chronic Kidney Disease")]
        public IList<IList<object>> ChronicKidneyDisease { get; set; }

        [JsonProperty("Age-Related Macular Degeneration")]
        public IList<IList<object>> AgeRelatedMacularDegeneration { get; set; }

        [JsonProperty("Glaucoma")]
        public IList<IList<object>> Glaucoma { get; set; }

        [JsonProperty("Cone-Rod Dystrophy")]
        public IList<IList<object>> ConeRodDystrophy { get; set; }

        [JsonProperty("Chronic Obstructive Pulmonary Disease")]
        public IList<IList<object>> ChronicObstructivePulmonaryDisease { get; set; }

        [JsonProperty("Asthma")]
        public IList<IList<object>> Asthma { get; set; }

        [JsonProperty("Alzheimer'S Disease")]
        public IList<IList<object>> AlzheimerSDisease { get; set; }

        [JsonProperty("Amyloidosis")]
        public IList<IList<object>> Amyloidosis { get; set; }

        [JsonProperty("Anxiety")]
        public IList<IList<object>> Anxiety { get; set; }

        [JsonProperty("Autism")]
        public IList<IList<object>> Autism { get; set; }

        [JsonProperty("Parkinson'S Disease")]
        public IList<IList<object>> ParkinsonSDisease { get; set; }

        [JsonProperty("Schizophrenia ")]
        public IList<IList<object>> Schizophrenia { get; set; }

        [JsonProperty("Bloom Syndrome")]
        public IList<IList<object>> BloomSyndrome { get; set; }

        [JsonProperty("Cystic Fibrosis")]
        public IList<IList<object>> CysticFibrosis { get; set; }

        [JsonProperty("Depression")]
        public IList<IList<object>> Depression { get; set; }

        [JsonProperty("Epilepsy")]
        public IList<IList<object>> Epilepsy { get; set; }

        [JsonProperty("Gout")]
        public IList<IList<object>> Gout { get; set; }

        [JsonProperty("Hemochromatosis")]
        public IList<IList<object>> Hemochromatosis { get; set; }

        [JsonProperty("Anemia")]
        public IList<IList<object>> Anemia { get; set; }

        [JsonProperty("Beta Thalassemia")]
        public IList<IList<object>> BetaThalassemia { get; set; }

        [JsonProperty("Hemophilia")]
        public IList<IList<object>> Hemophilia { get; set; }

        [JsonProperty("Glycogen Storage Disease")]
        public IList<IList<object>> GlycogenStorageDisease { get; set; }

        [JsonProperty("Rheumatoid Arthritis")]
        public IList<IList<object>> RheumatoidArthritis { get; set; }

        [JsonProperty("Scoliosis")]
        public IList<IList<object>> Scoliosis { get; set; }

        [JsonProperty("Multiple Sclerosis")]
        public IList<IList<object>> MultipleSclerosis { get; set; }

        [JsonProperty("Ulcerative Colitis")]
        public IList<IList<object>> UlcerativeColitis { get; set; }

        [JsonProperty("Crohn'S Disease")]
        public IList<IList<object>> CrohnSDisease { get; set; }

        [JsonProperty("Vitiligo")]
        public IList<IList<object>> Vitiligo { get; set; }

        [JsonProperty("Alopecia Areata")]
        public IList<IList<object>> AlopeciaAreata { get; set; }

        [JsonProperty("Anorexia")]
        public IList<IList<object>> Anorexia { get; set; }
    }

    public class Table2
    {

        [JsonProperty("trait")]
        public string Trait { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("all_outcomes")]
        public IList<string> AllOutcomes { get; set; }
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
        public IList<Table2> Table2 { get; set; }

        [JsonProperty("table3")]
        public string Table3 { get; set; }

        [JsonProperty("disclaimer")]
        public IList<IList<string>> Disclaimer { get; set; }

        [JsonProperty("graphical_version")]
        public int GraphicalVersion { get; set; }

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
