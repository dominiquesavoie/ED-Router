﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Router.VoiceAttack.Commands
{
	public interface ICommand
	{
		string Command { get; }
		bool Execute();
	}
}
