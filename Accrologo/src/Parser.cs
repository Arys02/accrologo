using System;
using System.Collections.Generic;
using System.Drawing;

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
                        parseLeft(tokenList, turtle, g);
                        break;
                    case "RIGHT":
                        System.Console.WriteLine("right");
                        parseRight(tokenList, turtle, g);
                        break;
                    case "REPEAT":
                        Console.WriteLine("repeat");
                        parseRepeat(tokenList, turtle, g);
                        break;
                    default:
                        using (Font myFont = new Font("Arial", 14))
                        {
                            g.DrawString("ERROR : Instruction expected", myFont, Brushes.Green, new Point(2, 2));
                        }
                        break;
                }
            }
        }

        private void parseForward(Queue<string> tokenList, Tortoise turtle, System.Drawing.Graphics g)
        {
            turtle.updateAndMove(getNumber(tokenList, g), g);
        }

        private void parseLeft(Queue<string> tokenList, Tortoise turtle, Graphics g)
        {
            turtle.turnLeft(getNumber(tokenList, g));
        }

        private void parseRight(Queue<string> tokenList, Tortoise turtle, Graphics g)
        {
            turtle.turnRight(getNumber(tokenList, g));
        }

        private void parseRepeat(Queue<string> tokenList, Tortoise turtle, System.Drawing.Graphics g)
        {
            int repeatNumber = getNumber(tokenList, g);
            string token = tokenList.Dequeue();
            if (token != "LEFTBRACE")
            {
                using (Font myFont = new Font("Arial", 14))
                {
                    g.DrawString("ERROR : Opening missing after number", myFont, Brushes.Green, new Point(2, 2));
                    return;
                }
            }

            Queue<string> subTokenQueue = new Queue<string>();
            while ((tokenList.Count != 0) && (tokenList.Peek() != "RIGHTBRACE"))
            {
                subTokenQueue.Enqueue(tokenList.Dequeue());
            }

            if (tokenList.Count == 0)
            {
                using (Font myFont = new Font("Arial", 14))
                {
                    g.DrawString("ERROR : Closing missing after instructions", myFont, Brushes.Green, new Point(2, 2));
                    return;
                }
            }

            for (int i = 0; i < repeatNumber; ++i)
            { 
                Parse(cloneQueue(subTokenQueue), turtle, g);
            }
            tokenList.Dequeue();
        }
        private bool isTokenNumber(Queue<string> tokenList)
        {
            return tokenList.Count != 0 && tokenIntDict.ContainsKey(tokenList.Peek());
        }

        private Queue<string> cloneQueue(Queue<string> queue)
        {
            Queue<string> cloneQueue = new Queue<string>();
            foreach (var VARIABLE in queue)
                cloneQueue.Enqueue(VARIABLE);
            return cloneQueue;
        }
        private int getNumber(Queue<string> tokenList, Graphics g)
        {
            if (!isTokenNumber(tokenList))
            {
                using (Font myFont = new Font("Arial", 14))
                {
                    g.DrawString("ERROR : Number expected", myFont, Brushes.Green, new Point(2, 2));
                    return 0;
                }
            }

            int number = 0;

            while(isTokenNumber(tokenList))
            {
                int tokenNumber;
                if (tokenIntDict.TryGetValue(tokenList.Dequeue(), out tokenNumber))
                {
                    number = number * 10 + tokenNumber;
                }
            }
            return number;
        }
    }
}