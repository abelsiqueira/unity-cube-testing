using UnityEngine;
using System.Collections;

public class StateCubeFlee_Flee : State<CubeFlee> {

	private Transform transform;
	private Vector3 direction;
	
	public override void Execute (CubeFlee context) {
		transform = context.transform;
		transform.rotation = Random.rotation;
		direction = Vector3.forward;
		direction = 4.0f*transform.TransformDirection(direction);
		context.SetDirection(direction);
	}
	
	public override void Enter (CubeFlee context) {
		Debug.Log("Enter Patrol");
	}
	
	public override void Exit (CubeFlee context) {
		Debug.Log("Exit Patrol");
	}
	
}
