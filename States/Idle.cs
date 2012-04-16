using UnityEngine;
using System.Collections;


public class Idle : State {
	
	private Idle () {
		state = states.en_Idle;
	}
	
	private static Idle instance = new Idle();
	
	public static Idle Instance() {
		return instance;
	}
		
	public override void Execute (Entity context) {
		context.SetDirection(Vector3.zero);
		context.SetFace(context.transform.right);
	}
	
	public override void Enter (Entity context) {
		Debug.Log("Enter Idle");
	}
	
	public override void Exit (Entity context) {
		Debug.Log("Exit Idle");
	}
}
