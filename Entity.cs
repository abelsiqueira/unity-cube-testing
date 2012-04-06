using UnityEngine;
using System.Collections;

[RequireComponent (typeof (CharacterController))]
public class Entity : MonoBehaviour {

	private int m_ID;
	protected FSM m_fsm;
	
	public FSM GetFSM () {
		return m_fsm;
	}
	
	public void ChangeState (State st) {
		m_fsm.ChangeState(st);
	}
}
