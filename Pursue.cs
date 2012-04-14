using UnityEngine;
using System.Collections;

public class Pursue : State {
	
	private Transform transform;
	private Transform target;
	private Vector3 direction;
	
	public void Awake () {
		state = 1;
	}
	
	public override void Enter (Entity context) {
		Debug.Log("Enter Patrol");
	}
	
	public override void Execute (Entity context) {
		target = context.medrash.transform;
		transform = context.transform;
		direction = target.position - transform.position;
		direction.y = 0;
		direction = 2.0f*direction.normalized;
		context.SetDirection(direction);
	}
	
	public override void Exit (Entity context) {
		Debug.Log("Exit Pursue");
	}
}
