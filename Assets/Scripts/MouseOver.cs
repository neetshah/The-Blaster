using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseOver : MonoBehaviour {

	private static MouseOver ins;

	[SerializeField]
	private Text info;
    private Image image;

	public static MouseOver MyIns{
		get{ 
			if (ins == null) {
				ins = FindObjectOfType<MouseOver> ();
				Debug.Log(ins + " is an active object " + ins.GetInstanceID());
			}

			return ins;
		}

	}
	void start(){
		info = GameObject.Find ("Arena2ToolTip").GetComponentInChildren<Text> ();
		info.gameObject.SetActive (false);
	}

	public void hide(){
		info = GameObject.Find ("Arena2ToolTip").GetComponentInChildren<Text> ();
		info.text = " ";
	}

	public void ShowToolTip(string tHov){
		info = GameObject.Find ("Arena2ToolTip").GetComponentInChildren<Text> ();

		if ( string.Compare(tHov,"Arena2Text") == 0) {
			info.text = " Arena 2\n Planet: Neptune \n Reward: 200 \n ";
		} else if ( string.Compare(tHov,"Arena3Text") == 0) {
			info.text = " Arena 3\n Planet: Titan \n Reward: 250 \n ";
		} else if ( string.Compare(tHov,"Arena4Text") == 0) {
			info.text = " Arena 4\n " + " Planet: Mars \n Reward: 300 \n ";
		} else if ( string.Compare(tHov,"Arena1Text") == 0) {
			info.text = " Arena 1\n Planet: Earth \n Reward: 400 \n ";
		} 
	}

}
