using UnityEngine;
using System.Collections;

public class FSM<T> {
	private T m_Owner;
	private State<T>  m_CurrentState;
	private State<T>  m_PreviousState;
	private State<T>  m_GlobalState;
	
	public FSM (T owner) {
		m_Owner = owner;
		m_CurrentState = null;
		m_PreviousState = null;
		m_GlobalState = null;
	}
	
	public void SetCurrentState (State<T> s) {
		m_CurrentState = s;
	}
	
	public void SetGlobalState (State<T> s) {
		m_GlobalState = s;
	}
	
	public void SetPreviousState (State<T> s) {
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
	
	public void ChangeState (State<T> newState) {
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
	
	public State<T> getCurrentState () {
		return m_CurrentState;
	}
	
	public State<T> getGlobalState () {
		return m_GlobalState;
	}
	
	public State<T> getPreviousState () {
		return m_PreviousState;
	}
}
