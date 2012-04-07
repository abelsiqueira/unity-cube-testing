using UnityEngine;
using System;

public class CubeFlee : Entity {

	public CubeFlee () {
		m_fsm = new FSM(this);
		m_ID = 1;
	}
	
	void Start () {
		m_fsm.SetCurrentState (new Idle());
		controller = GetComponent<CharacterController>();
		StartCoroutine(m_fsm.UpdateFSM());
	}
	
}
