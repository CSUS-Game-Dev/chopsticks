using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class NetworkManager : MonoBehaviour {

	public static NetworkManager networkManager;
	
	private string server_address = "localhost:3000";
	//private string server_address = "Server address here";


	void Start(){
		networkManager = this;

		sendTestMessageToServer();
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.Space)){
			sendTestMessageToServer(Time.time);
		}
	}

	public void sendTestMessageToServer(){
		WWWForm testForm = new WWWForm();
		JSONObject json = new JSONObject();
		json.AddField("Message", "Hello!");
		testForm.AddField("Info", json.ToString());
		//dtestForm.data = (byte)json.ToString();

		StartCoroutine(sendMessage(testForm, parseResponse));

	}

	public void sendTestMessageToServer(float value){
		WWWForm testForm = new WWWForm();
		JSONObject json = new JSONObject();
		json.AddField("Message", "Hello!");
		json.AddField("Time passed", value);
		testForm.AddField("Info", json.ToString());
		//dtestForm.data = (byte)json.ToString();

		StartCoroutine(sendMessage(testForm, parseResponse));

	}

	IEnumerator sendMessage(WWWForm form, Action response){
		WWW www = new WWW(server_address, form);
		
		yield return www;

		Debug.Log(www.text);

		//JSONObject json = new JSONObject(www.text);

		yield return null;
	}

	public void parseResponse(){

	}

}
