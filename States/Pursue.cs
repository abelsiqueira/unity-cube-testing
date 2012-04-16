using UnityEngine;
using System.Collections;

public class Pursue : State {
	
	private Transform transform;
	private Transform target;
	private Vector3 direction;
	
	private static Pursue instance = new Pursue();
	
	public static Pursue Instance() {
		return instance;
	}
	
	private Pursue () {
		state = states.en_Pursue;
	}
	
	public override void Enter (Entity context) {
		Debug.Log("Enter Pursue");
	}
	
	public override void Execute (Entity context) {
		target = context.medrash.transform;
		transform = context.transform;
		direction = target.position - transform.position;
		direction.y = 0;
		direction = 2.0f*direction.normalized;
		context.SetDirection(direction);
		//context.SetFace(direction);
		//context.transform.forward = direction;
	}
	
	public override void Exit (Entity context) {
		Debug.Log("Exit Pursue");
	}
}
