﻿using CommandPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.RemoteControl.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute(){ }
        public void Undo(){ }
    }
}
