using UnityEngine;
using System.Collections;

public class Patrol : State {
	
	private int count = 0;
	
	public override void Execute (Entity context) {
		count++;
		if (count > 30) {
			context.ChangeState(new Idle());
			count = 0;
		}
	}
	
	public override void Enter (Entity context) {
		Debug.Log("Enter Patrol");
	}
	
	public override void Exit (Entity context) {
		Debug.Log("Exit Patrol");
	}
}
