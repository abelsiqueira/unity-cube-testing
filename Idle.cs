using UnityEngine;
using System.Collections;

public class Idle : State {
	
	private int count = 0;
	
	public override void Execute (Entity context) {
		count++;
		if (count > 30) {
			context.ChangeState(new Patrol());
			count = 0;
		}
	}
	
	public override void Enter (Entity context) {
		Debug.Log("Enter Idle");
	}
	
	public override void Exit (Entity context) {
		Debug.Log("Exit Idle");
	}
}
