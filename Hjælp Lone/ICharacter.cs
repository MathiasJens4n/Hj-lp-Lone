﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_Lone
{
    internal interface ICharacter
    {
        void Heal();
        void Die();
        void Fight();
    }
}
