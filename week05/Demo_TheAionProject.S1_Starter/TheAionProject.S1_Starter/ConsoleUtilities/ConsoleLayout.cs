﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// static class sets the layout of the game screen
    /// </summary>
    public static class ConsoleLayout
    {
        //
        // console window configuration
        //
        public static int WindowWidth = 150;
        public static int WindowHeight = 40;
        public static int WindowPositionLeft = 0;
        public static int WindowPositionTop = 0;

        //
        // header configuration
        //
        // Note: The header height is the sum of lines of text and 2 blank lines.
        //       The top positions of other elements should be adjusted accordingly and
        //       the number of lines of text displayed by the header should not change.
        public static int HeaderWidth = 150;
        public static int HeaderPositionLeft = 0;
        public static int HeaderPositionTop = 0;

        //
        // footer configuration
        //
        // Note: The footer height is the sum of lines of text and 2 blank lines.
        //       The heights of other elements should be adjusted accordingly and
        //       the number of lines of text displayed by the footer should not change.
        public static int FooterWidth = 150;
        public static int FooterPositionLeft = 0;
        public static int FooterPositionTop = 37;

        //
        // menu box configuration
        //
        public static int MenuBoxWidth = 73;
        public static int MenuBoxHeight = 7;
        public static int MenuBoxPositionLeft = 1;
        public static int MenuBoxPositionTop = 3;

        //
        // message box configuration
        //
        public static int MessageBoxWidth = 148;
        public static int MessageBoxHeight = 23;
        public static int MessageBoxPositionLeft = 1;
        public static int MessageBoxPositionTop = 10;

        //
        // input box configuration
        //
        public static int InputBoxWidth = 148;
        public static int InputBoxHeight = 4;
        public static int InputBoxPositionLeft = 1;
        public static int InputBoxPositionTop = 33;

        //
        // status box configuration
        //
        public static int StatusBoxWidth = 74;
        public static int StatusBoxHeight = 7;
        public static int StatusBoxPositionLeft = 75;
        public static int StatusBoxPositionTop = 3;
    }
}