using UnityEngine;
using System.Collections;

public class StateCubeFlee_Idle : State<CubeFlee> {
	
	private int count = 0;
	
	public override void Execute (CubeFlee context) {
		count++;
		if (count > 10) {
			context.ChangeState(new StateCubeFlee_Flee());
			count = 0;
		}
		context.SetDirection(Vector3.zero);
	}
	
	public override void Enter (CubeFlee context) {
		Debug.Log("Enter " + context.name);
	}
	
	public override void Exit (CubeFlee context) {
		Debug.Log("Exit Idle");
	}
}
