using UnityEngine;
using System.Collections;

/*enum Entities {
	entity_CubeSeek,
	entity_CubeFlee
};*/

[RequireComponent (typeof (CharacterController))]
public class Entity : MonoBehaviour {

	protected int m_ID;
	
	public GameObject medrash;
	protected CharacterController controller;
	protected Vector3 direction;
	protected float d = 1.0f, r = 2.0f, R = 10.0f;
	protected FSM fsm;	
	
	public void SetMedrash(GameObject obj) {
		medrash = obj;
	}
	
	public FSM GetFSM () {
		return fsm;
	}
	
	public void ChangeState (State st) {
		fsm.ChangeState(st);
	}
	
	public void Update () {
		controller.Move(Time.deltaTime * direction);
	}
	
	public CharacterController GetController () {
		return controller;
	}
	
	public void SetDirection (Vector3 v) {
		direction = v;
	}
}
