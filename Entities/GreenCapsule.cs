using UnityEngine;
using System.Collections;

public class GreenCapsule : Entity {
	
	public void Awake () {
		fsm = new FSM(this);
	}
	
	void Start () {
		fsm.SetCurrentState (Idle.Instance());
		controller = GetComponent<CharacterController>();
		StartCoroutine(fsm.UpdateFSM());
		StartCoroutine(UpdateGreenCapsule());
	}
	
	public IEnumerator UpdateGreenCapsule() {
		while (true) {
			switch (fsm.getCurrentState()) {
			case State.states.en_Idle:
				IdleVerifications();
				break;
			case State.states.en_Pursue:
				PursueVerifications();
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
			fsm.ChangeState(Pursue.Instance());
	}
	
	private void PursueVerifications () {
		float dist = DistanceToMedrash();
		if (dist > R)
			fsm.ChangeState(Idle.Instance());
	}
	
}
