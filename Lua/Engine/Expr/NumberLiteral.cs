﻿using System.Globalization;

namespace Language.Lua
{
    public partial class NumberLiteral : Term
    {
        public override LuaValue Evaluate(LuaTable enviroment)
        {
            double number;

            if (string.IsNullOrEmpty(this.HexicalText))
            {
                number = double.Parse(this.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent | NumberStyles.AllowLeadingSign);
            }
            else
            {
                number = int.Parse(this.HexicalText, NumberStyles.HexNumber);
            }

            return new LuaNumber(number);
        }
    }
}