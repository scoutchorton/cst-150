namespace Activity14 {

    enum Tense {
        NORMAL,
        PAST,
        PRESENT
    }
    enum Conjugation {
        IO,
        TU,
        LUI_LEI_LI,
        NOI,
        VOI,
        LORO,
        INFINITIVE // no conjugation
    }
    enum VerbEnding {
        ARE,
        IRE,
        ERE
    }

    class Verb {
        string root;
        VerbEnding ending;

        public Verb(string root, VerbEnding ending) {
            this.root = root;
            this.ending = ending;
        }

        public string conjugate(Conjugation c, Tense t) {
            string beginning = "";
            string word = root;
            string suffix = "";

            // Base case that should be handled first regardless of tense
            if(c == Conjugation.INFINITIVE) {
                switch(ending) {
                    case VerbEnding.ARE:
                        suffix = "are";
                        break;
                    case VerbEnding.IRE:
                        suffix = "ire";
                        break;
                    case VerbEnding.ERE:
                        suffix = "ere";
                        break;
                }
            // Tense is like infinitive except with a beginning (stare -> am/I am ...ing, avere -> have/I have ...ed)
            } else if(t == Tense.PRESENT) {
                switch(c) {
                    case Conjugation.IO:
                        beginning = "sto";
                        break;
                    case Conjugation.TU:
                        beginning = "stai";
                        break;
                    case Conjugation.LUI_LEI_LI:
                        beginning = "sta";
                        break;
                    case Conjugation.NOI:
                        beginning = "stiamo";
                        break;
                    case Conjugation.VOI:
                        beginning = "state";
                        break;
                    case Conjugation.LORO:
                        beginning = "stanno";
                        break;
                }
                beginning += " ";

                switch(ending) {
                    case VerbEnding.ARE:
                        suffix = "ando";
                        break;
                    case VerbEnding.IRE:
                    case VerbEnding.ERE:
                        suffix = "endo";
                        break;
                }
            } else if(t == Tense.PAST) {
                switch(c) {
                    case Conjugation.IO:
                        beginning = "ho";
                        break;
                    case Conjugation.TU:
                        beginning = "hai";
                        break;
                    case Conjugation.LUI_LEI_LI:
                        beginning = "ha";
                        break;
                    case Conjugation.NOI:
                        beginning = "abbiamo";
                        break;
                    case Conjugation.VOI:
                        beginning = "avete";
                        break;
                    case Conjugation.LORO:
                        beginning = "hanno";
                        break;
                }
                beginning += " ";

                switch(ending) {
                    case VerbEnding.ARE:
                        suffix = "ato";
                        break;
                    case VerbEnding.IRE:
                        suffix = "ito";
                        break;
                    case VerbEnding.ERE:
                        suffix = "uto";
                        break;
                }
            // Handle regular suffix if not set yet
            } else {
                switch(c) {
                    case Conjugation.IO:
                        suffix = "o";
                        break;
                    case Conjugation.TU:
                        suffix = "i";
                        
                        // Don't double 'i' to make 'mangii'
                        if(root == "mangi")
                            suffix = "";
                        break;
                    case Conjugation.LUI_LEI_LI:
                        suffix = "a";
                        break;
                    case Conjugation.NOI:
                        suffix = "iamo";

                        // Don't double 'i' to make 'mangiiamo'
                        if(root == "mangi")
                            suffix = "";
                        break;
                    case Conjugation.VOI:
                        suffix = "ate";
                        break;
                    case Conjugation.LORO:
                        suffix = "ano";
                        break;
                }
            }

            // Combine parts together to make the final word
            return beginning + root + suffix;
        }
    }
}