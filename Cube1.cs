using UnityEngine;
using System;

public class Cube1 : Entity {

	public Cube1 () {
		m_fsm = new FSM(this);
		m_fsm.SetCurrentState (new Idle());
	}
	
	void Start () {
		StartCoroutine(m_fsm.UpdateFSM());
	}
	
}
