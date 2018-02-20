using System.Collections.Generic;

namespace Accrologo
{
    public class Parser
    {
        /**
         * LOGO GRAMMAR *
         * <instrs> := <instr> { <instr> };
         * <instr> :=
         * | <move>
         * | <loop>
         * | <sub_declaration>
         * | <sub_execution>
         * <move> :=
         * | "forward" num;
         * | "left" num;
         * | "right" num;
         * <loop> :=
         * | "repeat" num "[" <instrs> "]" ;
         * <sub_declaration> :=
         * | "to" id <instrs> "end" ;
         * <sub_execution> := 
         * | id
         */

        /**
         * TOKEN *
         * FORWARD
         * LEFT
         * RIGHT
         * REPEAT
         * LEFTBRACE "["
         * RIGHTBRACE "]"
         * TO
         * END
         */

        private Dictionary<string, int> tokenIntDict = new Dictionary<string, int>()
        {
            {"ZERO" , 0 },
            {"ONE"  , 1 },
            {"TWO"  , 2 },
            {"THREE", 3 },
            {"FOUR" , 4 },
            {"FIVE" , 5 },
            {"SIX"  , 6 },
            {"SEVEN", 7 },
            {"EIGHT", 8 },
            {"NINE" , 9 }
        };

        private List<string> tokenInstrList = new List<string>()
        {
            "FORWARD",
            "LEFT",
            "RIGHT",
            "REPEAT",
        };

        private List<string> tokenBraceList = new List<string>()
        {
            "LEFTBRACE",
            "RIGHTBRACE"
        };
        public Parser()
        {

        }

        public void Parse(Queue<string> tokenList, Tortoise turtle, System.Drawing.Graphics g)
        {
            while(tokenList.Count != 0)
            {
                string token = tokenList.Dequeue();

                switch (token)
                {
                    case "FORWARD":
                        System.Console.WriteLine("forward");
                        parseForward(tokenList, turtle, g);
                        break;
                    case "LEFT":
                        System.Console.WriteLine("left");
                        break;
                    case "RIGHT":
                        System.Console.WriteLine("right");
                        break;
                }

                    
            }
        }

        public void parseForward(Queue<string> tokenList, Tortoise turtle, System.Drawing.Graphics g)
        {
            if (tokenList.Count != 0 && tokenIntDict.ContainsKey(tokenList.Peek()))
            {
                int number = getNumber(tokenList);
                turtle.updateAndMove(number, g);
            }
        }

        public int getNumber(Queue<string> tokenList)
        {
            int number = 0;

            int tokenNumber;
            while(tokenList.Count != 0 && tokenIntDict.ContainsKey(tokenList.Peek()))
            {
                if (tokenIntDict.TryGetValue(tokenList.Dequeue(), out tokenNumber))
                {
                    number = number * 10 + tokenNumber;
                }
            }
            return number;
        }
    }
}