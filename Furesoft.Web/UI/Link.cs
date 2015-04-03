﻿using System;

namespace Furesoft.Web.UI
{
    public class Link
    {
        public string Name { get; set; }
        public string Inner { get; set; }
        public string Href { get; set; }
        public Style Style { get; set; }

        public Link()
        {
            Style = new Style();
        }

        public static implicit operator string(Link btn)
        {
            return btn.ToString();
        }

        public override string ToString()
        {
            return string.Format("<a name='{0}' href='{1}' style='{2}'>{3}</a>", Name, Href, Style, Inner);
        }
    }
}