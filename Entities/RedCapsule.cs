using UnityEngine;
using System.Collections;

public class RedCapsule : Entity {
	
	public void Awake () {
		fsm = new FSM(this);
	}
	
	void Start () {
		fsm.SetCurrentState (Idle.Instance());
		controller = GetComponent<CharacterController>();
		StartCoroutine(fsm.UpdateFSM());
		StartCoroutine(UpdateRedCapsule());
	}
	
	public IEnumerator UpdateRedCapsule() {
		while (true) {
			switch(fsm.getCurrentState()) {
			case State.states.en_Idle:
				IdleVerifications();
				break;
			case State.states.en_Flee:
				FleeVerifications();
				break;
			}
			yield return new WaitForSeconds(0.1f);
		}
	}
	
	private float DistanceToMedrash () {
		Vector3 d = medrash.transform.position - transform.position;
		return d.magnitude;
	}
	
	private void IdleVerifications () {
		float dist = DistanceToMedrash();
		if (dist < r)
			fsm.ChangeState(Flee.Instance());
	}
	
	private void FleeVerifications () {
		float dist = DistanceToMedrash();
		if (dist > R)
			fsm.ChangeState(Idle.Instance());
	}
	
}
