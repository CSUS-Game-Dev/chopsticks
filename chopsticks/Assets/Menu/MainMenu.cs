using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public Animator animator;
	public MenuParticleScript particles;
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
		StartCoroutine(waitForMenuFadeout(fadeInCredits));
	}

	IEnumerator waitForMenuFadeout(Action callback){
		int layerNum = animator.GetLayerIndex("Base Layer");
		while(animator.GetCurrentAnimatorStateInfo(layerNum).IsName("Menu_Exit_Anim") || animator.GetCurrentAnimatorStateInfo(layerNum).IsName("Menu_Idle")){
			yield return null;
		}

		callback();
	}

	public void fadeInCredits(){
		credits.SetActive(true);
		Animator creditsAnimator = credits.GetComponent<Animator>();
		creditsAnimator.SetTrigger("FadeIn");
	}

	public void creditsReturn(){
		Animator creditsAnimator = credits.GetComponent<Animator>();
		creditsAnimator.SetTrigger("FadeOut");
		StartCoroutine(waitForCreditsFadeOut(creditsAnimator, fadeIn));
	}

	IEnumerator waitForCreditsFadeOut(Animator creditsAnimator, Action callback){
		int layerNumber = creditsAnimator.GetLayerIndex("Base Layer");
		while(creditsAnimator.GetCurrentAnimatorStateInfo(layerNumber).IsName("Credits_Fade_out") || creditsAnimator.GetCurrentAnimatorStateInfo(layerNumber).IsName("Idle") ){
			yield return null;
		}

		creditsAnimator.gameObject.SetActive(false);
		callback();
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
