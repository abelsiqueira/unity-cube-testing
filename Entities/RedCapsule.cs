using UnityEngine;
using System.Collections;

public class RedCapsule : Entity {
	
	public void Awake () {
		fsm = new FSM(this);
	}
	
	void Start () {
		fsm.SetCurrentState (new Idle());
		controller = GetComponent<CharacterController>();
		StartCoroutine(fsm.UpdateFSM());
		StartCoroutine(UpdateRedCapsule());
	}
	
	public IEnumerator UpdateRedCapsule() {
		while (true) {
			float dist = DistanceToMedrash();
			switch(fsm.getCurrentState()) {
			case 0:
				if (dist < r)
					fsm.ChangeState(new Flee());
				break;
			case 2:
				if (dist > R)
					fsm.ChangeState(new Idle());
				break;
			}
			yield return new WaitForSeconds(0.1f);
		}
	}
	
	private float DistanceToMedrash () {
		Vector3 d = medrash.transform.position - transform.position;
		return d.magnitude;
	}
	
}
