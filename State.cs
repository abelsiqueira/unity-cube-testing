using UnityEngine;
using System;



public abstract class State {
	
	//public enum states {en_Idle, en_Pursue, en_Flee};
	protected int state;
	
	public int getState () {
		return state;
	}
	
	public bool isState (int st) {
		if (state == st)
			return true;
		else
			return false;
	}
	
	public abstract void Execute (Entity context);
	
	public abstract void Enter (Entity context);
	
	public abstract void Exit (Entity context);
}
