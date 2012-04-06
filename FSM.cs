using UnityEngine;
using System.Collections;

public class FSM {
	private Entity m_Owner;
	private State  m_CurrentState;
	private State  m_PreviousState;
	private State  m_GlobalState;
	
	public FSM (Entity owner) {
		m_Owner = owner;
		m_CurrentState = null;
		m_PreviousState = null;
		m_GlobalState = null;
	}
	
	public void SetCurrentState (State s) {
		m_CurrentState = s;
	}
	
	public void SetGlobalState (State s) {
		m_GlobalState = s;
	}
	
	public void SetPreviousState (State s) {
		m_PreviousState = s;
	}
	
	public IEnumerator UpdateFSM() {
		while (true) {
			if (m_GlobalState != null)
				m_GlobalState.Execute (m_Owner);
			if (m_CurrentState != null)
				m_CurrentState.Execute (m_Owner);
			
			yield return new WaitForSeconds(0.1f);
		}
	}
	
	public void ChangeState (State newState) {
		if (newState == null)
			return;
		m_PreviousState = m_CurrentState;
		m_CurrentState.Exit (m_Owner);
		m_CurrentState = newState;
		m_CurrentState.Enter (m_Owner);
	}
	
	public void RevertState () {
		ChangeState (m_PreviousState);
	}
	
	public State getCurrentState () {
		return m_CurrentState;
	}
	
	public State getGlobalState () {
		return m_GlobalState;
	}
	
	public State getPreviousState () {
		return m_PreviousState;
	}
}
