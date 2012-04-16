using UnityEngine;
using System;

public abstract class State {
	
	public enum states {en_Idle, en_Pursue, en_Flee};
	protected states state;
	
	public states getState () {
		return state;
	}
	
	public bool isState (states st) {
		if (state == st)
			return true;
		else
			return false;
	}
	
	public abstract void Execute (Entity context);
	
	public abstract void Enter (Entity context);
	
	public abstract void Exit (Entity context);
}
