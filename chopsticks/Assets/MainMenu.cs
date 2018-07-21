using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public Animator animator;
	public GameObject credits;
	// Use this for initialization
	public Button playButton, playNetworkedButton, settingsButton, creditsButton;
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
		credits.SetActive(true);
	}

	public void fadeOut(){
		animator.SetTrigger("FadeOut");
		buttonsEnabled(false);
	}

	public void fadeIn(){
		animator.SetTrigger("FadeIn");
		buttonsEnabled(true);
	}

	private void buttonsEnabled(bool status){
		playButton.interactable = status;
		playNetworkedButton.interactable = status;
		settingsButton.interactable = status;
		creditsButton.interactable = status;
	}
}
