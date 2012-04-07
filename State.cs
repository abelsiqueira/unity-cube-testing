using UnityEngine;
using System;

public abstract class State<T> {
	public abstract void Execute (T context);
	
	public abstract void Enter (T context);
	
	public abstract void Exit (T context);
}
