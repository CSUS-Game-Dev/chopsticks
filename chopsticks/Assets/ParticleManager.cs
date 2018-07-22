using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour {

	public List<ParticleSystem> particle_systems;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			foreach(ParticleSystem ps in particle_systems){
				ps.Play();
			}
		}
	}
}
