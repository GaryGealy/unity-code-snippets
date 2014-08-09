#region File Description
//-----------------------------------------------------------------------------
// Template.cs
//
// Copyright (C) Allegro Interactive. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region using
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.Enums;
#endregion

public class _template : MonoBehaviour {
	
#region enums
#endregion
	
#region fields
	private Singleton gameSingleton;
	
#endregion
	
#region properties
#endregion
	
	
#region events
	void SetupSubscriptions() {
		
	}
	
#endregion
		
#region Initialize
	//The Start function is called after all Awake functions on all script instances have been called. 
	void Start() {
		SetupSubscriptions();
	}
	
	// Use Awake to set up references between scripts, and use Start to pass any information back and forth.
	void Awake() {
		gameSingleton = Singleton.Instance();
	}
#endregion
	
#region methods
	// Update is called once per frame
	void Update() {
	
	}
#endregion
	
#region GUI
#endregion

}
