using UnityEngine;
using System;

public class CubeSeek : Entity {
	
	public Transform seek;
	
	public CubeSeek () {
		m_fsm = new FSM(this);
		m_ID = 0;
	}
	
	void Start () {
		m_fsm.SetCurrentState (new Idle());
		controller = GetComponent<CharacterController>();
		StartCoroutine(m_fsm.UpdateFSM());
	}
	
}
