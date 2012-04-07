using UnityEngine;
using System;

public class CubeFlee : Entity {
	
	private FSM<CubeFlee> m_fsm;	
	private Transform flee = null;
	
	public FSM<CubeFlee> GetFSM () {
		return m_fsm;
	}
	
	public void ChangeState (State<CubeFlee> st) {
		m_fsm.ChangeState(st);
	}
	
	public CubeFlee () {
		m_fsm = new FSM<CubeFlee>(this);
		m_ID = 1;
	}
	
	void Start () {
		m_fsm.SetCurrentState (new StateCubeFlee_Idle());
		controller = GetComponent<CharacterController>();
		StartCoroutine(m_fsm.UpdateFSM());
	}
	
}
