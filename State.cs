using UnityEngine;
using System;

public abstract class State {
	public abstract void Execute (Entity context);
	
	public abstract void Enter (Entity context);
	
	public abstract void Exit (Entity context);
}
