using UnityEngine;
using System;

public class CubeSeek : Entity {
	
	public Transform seek;
	private FSM<CubeSeek> m_fsm;	
	
	public FSM<CubeSeek> GetFSM () {
		return m_fsm;
	}
	
	public void ChangeState (State<CubeSeek> st) {
		m_fsm.ChangeState(st);
	}
	
	public CubeSeek () {
		m_fsm = new FSM<CubeSeek>(this);
		m_ID = 0;
	}
	
	void Start () {
		m_fsm.SetCurrentState (new StateCubeSeek_Idle());
		controller = GetComponent<CharacterController>();
		StartCoroutine(m_fsm.UpdateFSM());
	}
	
}
