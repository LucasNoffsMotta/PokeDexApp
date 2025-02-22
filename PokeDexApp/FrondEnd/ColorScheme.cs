﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDexApp.FrondEnd
{
    public static class ColorScheme
    {
        public static Color primaryColor { get; set; }
        public static Color secondaryColor { get; set; }
        public static Color thirdColor { get; set; }

        public static readonly Dictionary<string, string> colors = new Dictionary<string, string>
        {
            { "Normal", "#D9D9D9" },   // Light Gray
            { "Fire", "#FFB5B5" },     // Light Red
            { "Water", "#A7DBFF" },    // Light Blue
            { "Electric", "#FFEB99" }, // Light Yellow
            { "Grass", "#A8F5A2" },    // Light Green
            { "Ice", "#D6F6FF" },      // Ice Blue
            { "Fighting", "#FFC7B2" }, // Light Salmon
            { "Poison", "#E2C7F0" },   // Light Lilac
            { "Ground", "#EBD8A3" },   // Light Beige
            { "Flying", "#C2E7F7" },   // Light Sky Blue
            { "Psychic", "#FFC2D1" },  // Light Pink
            { "Bug", "#D2F5A6" },      // Light Yellow-Green
            { "Rock", "#E0D4B9" },     // Light Sand
            { "Ghost", "#CDB7E8" },    // Light Lavender
            { "Dragon", "#B3CFFF" },   // Soft Blue
            { "Dark", "#C4C4C4" },     // Soft Gray
            { "Fairy", "#FDDDFD" },    // Light Pastel Pink
            { "Steel", "#D9E3E6" }     // Light Silver
        };

        public static Color BackGroundColor(string type)
        {
            var color = ColorTranslator.FromHtml(colors[type]);
            return color;
        }

        public static Color SubColor(Color mainColor, double correction)
        {
            double r = mainColor.R;
            double g = mainColor.G;
            double b = mainColor.B;

            //Darken
            if (correction < 0)
            {
                correction = 1 + correction;
                r *= correction;
                g *= correction;
                b *= correction;
            }


            //Lighten
            else
            {
                r = (255 - r) * correction + r;
                g = (255 - g) * correction + g;
                b = (255 - b) * correction + b;
            }

            return Color.FromArgb(mainColor.A, (byte)r, (byte)g, (byte)b);
        }

        public static void UpdateBtnColors(Button btn, Color mainColor)
        {
            btn.FlatAppearance.BorderColor = SubColor(mainColor, 0.5);
            btn.ForeColor = SubColor(mainColor, -1.0);
            btn.BackColor = SubColor(mainColor, 0.5);
        }

        public static void UpdateTextColor(Label lbl, Color mainColor)
        {
            lbl.ForeColor = SubColor(mainColor, -1.0);
            lbl.BackColor = SubColor(mainColor, 0.5);
        }

        public static Color ColorTransition(Color mainColor, Color target, int count)
        {
            double r_curr = mainColor.R;
            double g_curr = mainColor.G;
            double b_curr = mainColor.B;

            if (mainColor.R < target.R && count == 10000)
            {
                r_curr = mainColor.R + 1;
            }

            if (mainColor.G < target.G && count == 10000)
            {
                g_curr = mainColor.G + 1;
            }

            if (mainColor.B < target.B && count == 10000)
            {
                b_curr = mainColor.B + 1;
            }
         
            return Color.FromArgb(mainColor.A, (byte)r_curr, (byte)g_curr, (byte)b_curr);
        }
    }
}

