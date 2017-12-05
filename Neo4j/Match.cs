using System;
using System.Collections.Generic;

namespace DotNetSamples.Neo4j {
    public class Match {


        public List<ReturnItem> listReturnItems {get; private set;} = new List<ReturnItem>();

        public static Match Create() {
            return new Match();
        }

        public Match SetFrom(string variable, Type type, bool isReturned = true) {
            if(isReturned) {
                listReturnItems.Add(new ReturnItem(){Variable = variable, Type = type  });
            }
            return this;
        }

        public Match SetTo(string variable, Type type, bool isReturned = true) {
             if(isReturned) {
                listReturnItems.Add(new ReturnItem(){Variable = variable, Type = type  });
            }

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