﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoGo.NecroBot.Logic.Event;

namespace PoGo.Necrobot.Window.Model
{
    public class PokestopItemViewModel : SidebarItemViewModel
    {
        private FortUsedEvent ev;
        
        public string Name => ev.Name;

        public int EXP => ev.Exp; 
      
        public PokestopItemViewModel(FortUsedEvent ev)
        {
            this.ev = ev;
            UUID = ev.Id;

        }
    }
}
