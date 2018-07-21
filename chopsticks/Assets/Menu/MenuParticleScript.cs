using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuParticleScript : MonoBehaviour {

	public RectTransform canvas;
	public Camera mainCam;
	public Vector2 screenSize;

	private ParticleSystem particles;
	public float distanceAboveScreen;

	// Use this for initialization
	void Start () {
		Vector3 worldPos = mainCam.ScreenToWorldPoint(new Vector3(canvas.rect.width / 2, canvas.rect.height,0f));
		transform.position = new Vector3(worldPos.x, worldPos.y + distanceAboveScreen, 0f);

		particles = GetComponent<ParticleSystem>();

		setupDefaultMaterial();
		setParticleRunning(true); 
	}
	
	public void setupDefaultMaterial(){
		//particles.Stop();

	}

	public void setParticleRunning(bool running){
		if(running){particles.Play();}
		else{particles.Stop();}
	}
}
