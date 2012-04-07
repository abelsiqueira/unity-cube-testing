using UnityEngine;
using System.Collections;

/*enum Entities {
	entity_CubeSeek,
	entity_CubeFlee
};*/

[RequireComponent (typeof (CharacterController))]
public class Entity : MonoBehaviour {

	protected int m_ID;

	protected CharacterController controller;
	protected Vector3 direction;
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
