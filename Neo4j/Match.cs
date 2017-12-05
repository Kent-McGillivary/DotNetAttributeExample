using System;

namespace DotNetSamples.Neo4j {
    public class Match {


        public static Match Create() {
            return new Match();
        }

        public Match SetFrom(string variable, Type item, bool isReturned = true) {
            return this;
        }

        public Match SetTo(string variable, Type item, bool isReturned = true) {
            return this;
        }

        public Match SetTypeRelation(String typeRelation) {
            return this;
        }

        public Match Where(string variable, string value) {
            return this;
        }
    }
}