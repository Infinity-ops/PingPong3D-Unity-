using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreUI : MonoBehaviour {
	public int scorePlayerRight;
	public int scorePlayerLeft;
	public GUIStyle style;
	// Use this for GUI
	void OnGUI () {
		float x = Screen.width/2f;
		float y = 140f;
		float height = 10f;
		float width = 10f;
		string text = scorePlayerRight + "/" + scorePlayerLeft;
		GUI.Label (new Rect (x - (width /10f), y ,width,height),text,style);
	}
	

}
