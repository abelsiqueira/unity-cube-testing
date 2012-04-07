using UnityEngine;
using System.Collections;

public class StateCubeSeek_Patrol : State<CubeSeek> {
	
	private int count = 0;
	private Transform transform;
	private Vector3 direction;
	
	public override void Execute (CubeSeek context) {
		count++;
		if (count > 30) {
			context.ChangeState(new StateCubeSeek_Idle());
			count = 0;
		}
		
		transform = context.transform;
		direction = 3.0f*Vector3.forward;
		direction = transform.TransformDirection(direction);
		context.SetDirection(direction);
	}
	
	public override void Enter (CubeSeek context) {
		Debug.Log("Enter Patrol");
		
	}
	
	public override void Exit (CubeSeek context) {
		Debug.Log("Exit Patrol");
	}
}
