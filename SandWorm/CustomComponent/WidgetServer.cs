﻿using System;
using System.Drawing;
using Grasshopper.Kernel;
using Eto.Forms;

namespace SandWorm
{
    public sealed class WidgetServer
    {
        private static WidgetServer _instance;

        public Font TextFont
        {
            get;
            private set;
        }

        public Font DropdownFont
        {
            get;
            private set;
        }

        public Font MenuHeaderFont
        {
            get;
            private set;
        }

        public Font SliderValueTagFont
        {
            get;
            private set;
        }

        public Size RadioButtonSize
        {
            get;
            private set;
        }

        public int RadioButtonPadding
        {
            get;
            private set;
        }

        public Size CheckBoxSize
        {
            get;
            private set;
        }

        public int CheckBoxPadding
        {
            get;
            private set;
        }

        public static WidgetServer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WidgetServer();
                }
                return _instance;
            }
        }

        public static float GetScalingFactor()
        {
            float num = Screen.PrimaryScreen.LogicalPixelSize;
            if ((double)num > 0.95 && (double)num < 1.05)
            {
                num = 1f; // Windows scaling % as int; e.g. 200% = 2.0
            }
            return num;
        }

        public static int ScaleFontSize(int font_size)
        {
            // E.g. 8em at 100% scale; 4em at 200% scale
            return (int)Math.Round((double)font_size * (double)GH_FontServer.StandardAdjusted.Height / (double)GH_FontServer.Standard.Height);
        }

        private WidgetServer()
        {
            string name = "Arial";
            int num = ScaleFontSize(8);
            TextFont = new Font(new FontFamily(name), num, FontStyle.Regular);
            string name2 = "Arial";
            int num2 = ScaleFontSize(8);
            DropdownFont = new Font(new FontFamily(name2), num2, FontStyle.Italic);
            string name3 = "Arial";
            int num3 = ScaleFontSize(8);
            MenuHeaderFont = new Font(new FontFamily(name3), num3, FontStyle.Bold);
            string name4 = "Arial";
            int num4 = ScaleFontSize(10);
            SliderValueTagFont = new Font(new FontFamily(name4), num4, FontStyle.Italic);
            int width = 8;
            int height = 8;
            RadioButtonSize = new Size(width, height);
            RadioButtonPadding = 4;
            int width2 = 8;
            int height2 = 8;
            CheckBoxSize = new Size(width2, height2);
            CheckBoxPadding = 4;
        }
    }
}