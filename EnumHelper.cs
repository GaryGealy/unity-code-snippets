#region File Description
//-----------------------------------------------------------------------------
// cs
//
// Copyright (C) Allegro Interactive. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region using
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using System.Linq;

#endregion

namespace Game.Enums {

	public enum MouseButton { 
		Left = 0, 
		Right, 
		Middle
	}
	
	public enum ClickType {
		MouseUp = 0,
		MouseDown = 1
	}
}