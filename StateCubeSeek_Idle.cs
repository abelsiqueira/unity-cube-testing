using UnityEngine;
using System.Collections;

public class StateCubeSeek_Idle : State<CubeSeek> {
	
	private int count = 0;
	
	public override void Execute (CubeSeek context) {
		count++;
		if (count > 10) {
			context.ChangeState(new StateCubeSeek_Seek());
			count = 0;
		}
		context.SetDirection(Vector3.zero);
	}
	
	public override void Enter (CubeSeek context) {
		Debug.Log("Enter Idle");
	}
	
	public override void Exit (CubeSeek context) {
		Debug.Log("Exit Idle");
	}
}
