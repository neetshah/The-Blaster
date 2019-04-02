using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class LoadOnClick : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public GameObject loadingImage;

	public void LoadScene(int level)
	{
		loadingImage.SetActive(true);
		Application.LoadLevel(level);
	}


	#region IPointerEnterHandler implementation

	public void OnPointerEnter (PointerEventData eventData)
	{
		string t = eventData.pointerCurrentRaycast.gameObject.name;

		MouseOver.MyIns.ShowToolTip (t);
		Debug.Log ("Enter");
	}

	#endregion

	#region IPointerExitHandler implementation

	public void OnPointerExit (PointerEventData eventData)
	{
		MouseOver.MyIns.hide();
		Debug.Log ("Exit");
	}

	#endregion
	void onMouseOver ()
	{
		print (gameObject.name);
	}

}