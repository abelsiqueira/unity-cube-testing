using UnityEngine;
using System.Collections;


public class Idle : State {
	
	public Idle () {
		state = 0;
	}
		
	public override void Execute (Entity context) {
		context.SetDirection(Vector3.zero);
	}
	
	public override void Enter (Entity context) {
		Debug.Log("Enter Idle");
	}
	
	public override void Exit (Entity context) {
		Debug.Log("Exit Idle");
	}
}
