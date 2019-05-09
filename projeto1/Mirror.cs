﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo18Ghosts
{
    /// <summary>
    /// this class' purpose is to set the mirrors on the board by giving them
    /// their character and colour for the render
    /// </summary>
    sealed public class Mirror : BoardPiece
    {
        public Mirror()
            : base("M", ConsoleColor.White)
        {
        }
    }
    
}
