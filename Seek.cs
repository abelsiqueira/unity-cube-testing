using UnityEngine;
using System.Collections;

public class Seek : State {
	
	private int count = 0;
	private Transform transform;
	private Transform seek;
	private Vector3 direction;
	
	public override void Execute (Entity context) {
		count++;
		if (count > 30) {
			context.ChangeState(new Idle());
			count = 0;
		}
		
		transform = context.transform;
		//seek = context.seek;
		direction = 3.0f*Vector3.forward;
		direction = transform.TransformDirection(direction);
		context.SetDirection(direction);
	}
	
	public override void Enter (Entity context) {
		Debug.Log("Enter Patrol");
		
	}
	
	public override void Exit (Entity context) {
		Debug.Log("Exit Patrol");
	}
}
