using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//<---added
using System.Text;//<---added

namespace _CST407____VigenereCracker_AlgorithmTesting
{
    //_________________________________________________________________________________________________
    //CHARLES BABBAGES METHOD:
    //      FIND KEY LENGTH
    //      BREAK TEXT INTO KEY LENGTH SETS
    //      LETTER FREQUENCY ANALYSIS OF CEASAR GROUPS
    //      CRACKING VIGENERE BY UNWINDING WITH PROBABLE KEY
    //_________________________________________________________________________________________________
    class Program
    {
        //member variables
        static string mCipher = "YYCIISPRYSGYCHVVSHAKLXCCCKZKMPGPTQUAPKZIRZIVWMBSMWEVDMWFCVLKLLGKEKYYIMJDSTUZTVYG";//<---stores cipher message :NOTE: Can be changed here and will be text input in windows form app:"GENERALPHONGISREADYTHEKINGISINPLAYALLTHEPIECESMOVEATMIDNIGHTTHETARGETISLORDVADER"
        static string mAlphabet = "abcdefghijklmnopqrstuvwxyz";//<---used as an easier way to set key values, leaving the frequency file with only the corresponding double values: makes iteration and key value pair assignments easier :USEDIN: FillFreqDict()
        static string mFilePath = @"C:\Users\Jered\source\repos\[CST407] - VigenereCracker_AlgorithmTesting\FreqDict.txt";//<---file path to letter frequency file   
        static int mProbKeyLength = 0;//<---stores probable key length during string testing: initial value set to 0 :USEDIN: FindKeyLength(), CipherToKeyLenSets(), LetterFreqAnalysis()
        static Dictionary<char,double> mFrequency = new Dictionary<char, double>();//<---stores (key char)alphabet a-z: stores (value double)occurance probabilities :NOTE: Based on letter probabilities in the english language
        static List<string> mKeyLenSets = new List<string>();//<---stores sets of strings of key length = mProbKeyLength :RTRNBY: CipherToKeyLenSets()
        static List<string> mDiGraphList = new List<string>();//<---holds all 2 letter pattern repeats from cipher text: NOTE: Di graphs may not be very useful
        static List<string> mTriGraphList = new List<string>();//<---holds all 3 letter pattern repeats from cipher text
        static List<string> mQuadGraphList = new List<string>();//<---holds all 4 letter pattern repeats from cipher text
        
        //METHOD FUNCTIONS=========================================================================
        /*
        //  FUNC:   FillFreqDict(string arg)
        //  TASK:   Populates dictionary with alphabet letters and their corresponding frequency percentage values based on the english language
        //  ARGS:   Takes a string file path: loads the file based on path: parses through it filling the dictionary
        //  RTRN:   Dictionary
        */
        public static Dictionary<char,double> FillFreqDict(string filePath)
        {
            //local variables
            filePath = mFilePath;//<---set file path
            string line = String.Empty;//<---hold stream line for line by iteration
            Dictionary<char,double> tempDict = new Dictionary<char, double>();//<---gets filled by file stream iterator: is return variable
            char key;
            double value;

            //iterate through file stream
            using (StreamReader reader = File.OpenText(filePath))
            {
                //local variables
                int ndx = 0;//<---indexer for mAlphabet

                //fill dictionary with key value pairs
                while((line = reader.ReadLine()) != null)
                {
                    //set key value pairs
                    key = mAlphabet.ElementAt(ndx);//<---uses mAlphabet iteration to set keys
                    value = double.Parse(line);//<---uses file stream itrerator line variable to set values

                    //add key value pairs to dictionary
                    tempDict.Add(key, value);

                    //increment ndx
                    ndx++;
                }
            }

            //return temporary dictionary
            return tempDict;
        }
        /*
        //  FUNC:   GraphBuilder(int arg)
        //  TASK:   Builds graphs(di, tri, quad) based on passed in argument
        //  ARGS:   String cipher text
        //  RTRN:   List
        */
        public static List<string> GraphBuilder(int nGraph)
        {
            //local variables
            List<string> graphList = new List<string>();//<---stores all the nGraph strings: Is return variable
            string cipher = mCipher;//<---set cipher text: initialize to member variable mCipher
            string graph = String.Empty;//<---hold current iteration of graph string: initialize to empty string
            int cipherStringNdx = 0;//<---cipher text iterator index: initialize to 0
            int cipherLength = cipher.Length;//<---used for while loop control iterating through entire cipher text string: initialized to cipher string length
            char currentCharacter;//<---stores current character iteration being looked at
            
            //iterate through cipher text: TODO: MUST BE TWEAKED TO NOT ACCEPT NONE CHARACTERS
            while (cipherStringNdx < (cipherLength - 1))
            {
                //build graph(n character strings)
                for (int GraphNdx = 0; GraphNdx < nGraph;/**/)
                {
                    //set current = next character iteration from cipher text string
                    currentCharacter = cipher.ElementAt(cipherStringNdx);

                    //check is valid character
                    if (currentCharacter >= 'a' && currentCharacter <= 'z' || currentCharacter >= 'A' && currentCharacter <= 'Z')//<---lowercase a-z or uppercase A-Z 
                    {
                        graph += currentCharacter.ToString();
                        GraphNdx++;
                    }
                    else//<---not valid character
                    {
                        GraphNdx++;
                    }

                    //BREAK: meant to control the collection of remaining characters at end of cipher text that don't meet nGraph length: MAYNOTNEED
                    if (cipherStringNdx == (cipherLength - 1))
                        break;

                    //increment cipher string index
                    cipherStringNdx++;
                }//<---has 2 exit conditions: see BREAK

                //populate string lists
                graphList.Add(graph);

                //clean up
                graph = String.Empty;//<---reset graph string
            }

            //return graph list
            return graphList;
        }
        /*
        //  FUNC:   FindKeyLength (string arg)
        //  TASK:   Analyse cipher string to find repeated n-graphs in order to find probable key length
        //  ARGS:   String cipher text
        //  RTRN:   Int
        */
        public static int FindKeyWordLength(List<string> nGraphList)//<---could have 3 args for each nGraph list
        {
            //local variables
            //search for repeating patterns in graph
                //if repeat is found count (starting at 0) the number of characters from the first character of first pattern to first character of its repeat
                //store the repeated pattern as well as the distance between
                //this process with all graphs analysed together will show the most occurring possible numeric factors of the distance between pattern repeats: Example for 1 graph: Distance of 15 so factors 15, 5, 3, 1
            //set key length

            //return probable key length
            return mProbKeyLength;
        }
        /*
        //  FUNC:   CipherToKeyLenSetsAnalysis(string arg, int arg)
        //  TASK:   After the probable key is found, break the cipher text into string sets with length = mProbKeyLength: Uses LetterFrequencyAnalysis()
        //  ARGS:   String cipher text, integer probable key length
        //  RTRN:   String
        */
        public static string CipherToKeyLenSets(string cipher, int probKey)
        {
            return cipher;
        }
        /*
        //  FUNC:   LetterFreqAnalysis()
        //  TASK:   NOTE: Used in CipherKeyLenSets
        //  ARGS:   
        //  RTRN:   
        */

        //MAIN PROGRAM EXECUTION===================================================================
        static void Main(string[] args)
        {
            //Notes for testing
            //Cipher text  = YYCIISPRYSGYCHVVSHAKLXCCCKZKMPGPTQUAPKZIRZIVWMBSMWEVDMWFCVLKLLGKEKYYIMJDSTUZTVYG
            //Plain text = GENERALPHONGISREADYTHEKINGISINPLAYALLTHEPIECESMOVEATMIDNIGHTTHETARGETISLORDVADER
            //Key = SUPERSECRET
            //Key Length = 11

            //local variables
            int diGraph = 2;
            int triGraph = 3;
            int quadGraph = 4;
            Dictionary<char, double> FreqDict= new Dictionary<char, double>();
            List<string> diGraphList = new List<string>();
            List<string> triGraphList = new List<string>();
            List<string> quadGraphList = new List<string>();

            //fill dictionary(takes string filepath)
            FreqDict = FillFreqDict(mFilePath);

            //graph builder(takes int nGraph)
            diGraphList = GraphBuilder(diGraph);
            triGraphList = GraphBuilder(triGraph);
            quadGraphList = GraphBuilder(quadGraph);

            //find key length(takes List nGraphList)
            //FindKeyWordLength(/*nGraphList*/);

            //break cipher into key length sets(takes string ciphertext, int probableKeyLength): NOTE: function call likely to be in while loop printing updated decrypted cipher message during analysis
            //CipherToKeyLenSetsAnalysis(/*cipherText*/, /*probable key length*/): NOTE: Uses LetterFreqAnalysis()
        }
    }
}
