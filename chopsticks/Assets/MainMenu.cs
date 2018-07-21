using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public Animator animator;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void playLocalPressed(){
		fadeOut();
	}

	public void playNetworkedPressed(){
		fadeOut();
	}

	public void settingsPressed(){
		fadeOut();
	}

	public void creditsPressed(){
		fadeOut();
	}

	private void fadeOut(){
		animator.SetTrigger("FadeOut");
	}

	private void fadeIn(){
		animator.SetTrigger("FadeIn");
	}
}
