using UnityEngine;
using System.Collections;

public class StateCubeSeek_Seek : State<CubeSeek> {
	
	private Transform transform;
	private Transform seek;
	private Vector3 direction;
	
	public override void Execute (CubeSeek context) {
		transform = context.transform;
		seek = context.seek;
		direction = 2.0f*(seek.position - transform.position).normalized;
		context.SetDirection(direction);
	}
	
	public override void Enter (CubeSeek context) {
		Debug.Log("Enter Patrol");
	}
	
	public override void Exit (CubeSeek context) {
		Debug.Log("Exit Patrol");
	}
}
