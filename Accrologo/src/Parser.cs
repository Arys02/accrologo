﻿using System.Collections.Generic;

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

        public Parser()
        {

        }
    }
}