using UnityEngine;
using System.Collections.Generic;
using System;
	
[RequireComponent (typeof (CharacterController))]
[RequireComponent (typeof (ThirdPersonController))]
[RequireComponent (typeof (ThirdPersonCamera))]
public class Medrash : MonoBehaviour {
	
	public GameObject GreenCapsule;
	public GameObject RedCapsule;
	private List<Entity> ListOfEnemies = new List<Entity>();
	
	public void Start() {
		Vector3 position;
		GameObject inst;
		Entity entity;
		for (int i = 0; i < 8; i++) {
			double theta = i*Math.PI/4.0f, radius = 10;
			float dx = (float) (radius*Math.Cos(theta)), dz = (float) (radius*Math.Sin(theta));
			position = transform.position;
			position.x += dx;
			position.z += dz;
			while (Physics.Raycast(position, -Vector3.up, 1.0f))
			    position.y += 1.0f;
			
			if (i%2 == 0)
				inst = (GameObject) Instantiate(GreenCapsule, position, transform.rotation);
			else
				inst = (GameObject) Instantiate(RedCapsule, position, transform.rotation);
			
			entity = inst.GetComponent<Entity>();
			entity.SetMedrash(this.gameObject);
			ListOfEnemies.Add(entity);
		}
	}
	
}
