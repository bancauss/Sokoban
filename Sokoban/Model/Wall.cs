﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Wall : Tile
    {
        public Wall()
        {
          this._icon = '█';
        }

        public override bool CanEnter()
        {
             return false;
        }
    }
}
