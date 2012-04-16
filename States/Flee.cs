using UnityEngine;
using System.Collections;

public class Flee : State {
	
	private Transform transform;
	private Transform target;
	private Vector3 direction;
	
	private static Flee instance = new Flee();
	
	public static Flee Instance() {
		return instance;
	}
	
	private Flee () {
		state = states.en_Flee;
	}
	
	public override void Enter (Entity context) {
		Debug.Log("Enter Flee");
	}
	
	public override void Execute (Entity context) {
		target = context.medrash.transform;
		transform = context.transform;
		direction = target.position - transform.position;
		direction.y = 0;
		direction = -5.0f*direction.normalized;
		context.SetDirection(direction);
	}
	
	public override void Exit (Entity context) {
		Debug.Log("Exit Flee");
	}
}
