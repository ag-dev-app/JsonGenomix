using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonGenomix.JsonFile
{
    public class persn
    {
        public RootObject JsonData;

        public persn(string JsonFile)
        {
            JsonData = JsonConvert.DeserializeObject<RootObject>(JsonFile);

        }

        public class Table1
        {

            [JsonProperty("Empathy")]
            public IList<IList<string>> Empathy { get; set; }

            [JsonProperty("Leadership Potential")]
            public IList<IList<string>> LeadershipPotential { get; set; }

            [JsonProperty("Openness")]
            public IList<IList<string>> Openness { get; set; }

            [JsonProperty("Extraversion")]
            public IList<IList<string>> Extraversion { get; set; }

            [JsonProperty("Agreeableness")]
            public IList<IList<string>> Agreeableness { get; set; }

            [JsonProperty("Conscientiousness")]
            public IList<IList<string>> Conscientiousness { get; set; }

            [JsonProperty("Warrior Personality")]
            public IList<IList<string>> WarriorPersonality { get; set; }

            [JsonProperty("Worrier Personality")]
            public IList<IList<string>> WorrierPersonality { get; set; }

            [JsonProperty("Exploratory behaviour")]
            public IList<IList<string>> ExploratoryBehaviour { get; set; }

            [JsonProperty("Creativity")]
            public IList<IList<string>> Creativity { get; set; }

            [JsonProperty("Entrepreneurship potential")]
            public IList<IList<string>> EntrepreneurshipPotential { get; set; }

            [JsonProperty("Angry reaction")]
            public IList<IList<string>> AngryReaction { get; set; }

            [JsonProperty("Angry temperament")]
            public IList<IList<string>> AngryTemperament { get; set; }

            [JsonProperty("Optimism")]
            public IList<IList<string>> Optimism { get; set; }

            [JsonProperty("Self-esteem")]
            public IList<IList<string>> SelfEsteem { get; set; }

            [JsonProperty("Impulsivity")]
            public IList<IList<string>> Impulsivity { get; set; }

            [JsonProperty("Memory")]
            public IList<IList<string>> Memory { get; set; }

            [JsonProperty("Intelligence")]
            public IList<IList<string>> Intelligence { get; set; }

            [JsonProperty("Intelligence- Higher IQ when breast fed")]
            public IList<IList<string>> IntelligenceHigherIQWhenBreastFed { get; set; }

            [JsonProperty("General cognition")]
            public IList<IList<string>> GeneralCognition { get; set; }

            [JsonProperty("Maths Ability")]
            public IList<IList<string>> MathsAbility { get; set; }

            [JsonProperty("Verbal numerical reasoning")]
            public IList<IList<string>> VerbalNumericalReasoning { get; set; }

            [JsonProperty("Car driving skills")]
            public IList<IList<string>> CarDrivingSkills { get; set; }

            [JsonProperty("Educational attainment")]
            public IList<IList<string>> EducationalAttainment { get; set; }

            [JsonProperty("Reaction time")]
            public IList<IList<string>> ReactionTime { get; set; }

            [JsonProperty("Happiness")]
            public IList<IList<string>> Happiness { get; set; }

            [JsonProperty("Morning person")]
            public IList<IList<string>> MorningPerson { get; set; }

            [JsonProperty("Night owl")]
            public IList<IList<string>> NightOwl { get; set; }
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
}
