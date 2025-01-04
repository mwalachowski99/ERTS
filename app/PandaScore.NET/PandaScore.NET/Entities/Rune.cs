using Newtonsoft.Json;

namespace PandaScore.NET.Entities {
    public class Rune {
        [JsonProperty("id")]
        public int Id { get; private set; }
        [JsonProperty("name")]
        public string Name { get; private set; }

        public override bool Equals(object obj) {
            var runes = obj as Rune;
            return runes != null &&
                   Id == runes.Id;
        }

        public override int GetHashCode() {
            return 2108858624 + Id.GetHashCode();
        }
    }
}
