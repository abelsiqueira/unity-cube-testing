using UnityEngine;
using System.Collections;

public class GreenCapsule : Entity {
	
	public void Awake () {
		fsm = new FSM(this);
	}
	
	void Start () {
		fsm.SetCurrentState (new Idle());
		controller = GetComponent<CharacterController>();
		StartCoroutine(fsm.UpdateFSM());
		StartCoroutine(UpdateGreenCapsule());
	}
	
	public IEnumerator UpdateGreenCapsule() {
		while (true) {
			float dist = DistanceToMedrash();
			if ( (fsm.getCurrentState() == 0) && (dist < r) )
				fsm.ChangeState(new Pursue());
			else if ( (fsm.getCurrentState() == 1) && (dist > R) )
				fsm.ChangeState(new Idle());

			yield return new WaitForSeconds(0.1f);
		}
	}
	
	private float DistanceToMedrash () {
		Vector3 d = medrash.transform.position - transform.position;
		return d.magnitude;
	}
	
}
