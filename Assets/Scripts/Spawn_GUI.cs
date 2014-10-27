﻿/*Peter Aguiar
 * October 22-23, 2014
 * Spawn_GUI.cs spawns and controls the weapon UI. Either clicking the corresponding number key, rolling the mouse wheel, or clicking the
 * number directly changes the "index" value accordingly. 
 * 
 * October 23: The last button is reserved as a menu button for later, the current index is printed next to "menu".
 */
//=====================================================================================================================================================
using UnityEngine;
using System.Collections;

public class Spawn_GUI : MonoBehaviour {

	public float width_Offset; //beginning offset
	public float height_Offset;

	public GUIStyle style;

	public int index = 1; //current weapon selected, use this public int to know selected weapon.

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	void OnGUI(){
		width_Offset = Screen.width/8;
		height_Offset = 0;

		float button_Offset = 10; //offset between buttons

		float button_Size = 0.0663f; //button size

		GUI.Box (new Rect(width_Offset,height_Offset,Screen.width * 0.75f,Screen.height/10),""); //Background Box
//----------------------------------------------------------------------------------------------------------------------------------------------------

		style = new GUIStyle(GUI.skin.button);
		style.normal.textColor = Color.white;
		style.hover.textColor  = Color.cyan;
		style.active.textColor = Color.red;

		if (GUI.Button (new Rect (width_Offset + button_Offset , height_Offset +10 , Screen.width * button_Size, Screen.height * 0.08f),"1", style)) {
			index = 1;
		}
		button_Offset += Screen.width * button_Size; //next button moved over by the width of buttons
		if (GUI.Button (new Rect (width_Offset + button_Offset, height_Offset +10 , Screen.width * button_Size, Screen.height * 0.08f),"2", style)) {
			index = 2;
		}
		button_Offset += Screen.width * button_Size;
		if (GUI.Button (new Rect (width_Offset + button_Offset, height_Offset +10 , Screen.width * button_Size, Screen.height * 0.08f),"3", style)) {
			index = 3;
		}
		button_Offset += Screen.width * button_Size;
		if (GUI.Button (new Rect (width_Offset + button_Offset, height_Offset +10 , Screen.width * button_Size, Screen.height * 0.08f),"4", style)) {
			index = 4;
		}
		button_Offset += Screen.width * button_Size;
		if (GUI.Button (new Rect (width_Offset + button_Offset, height_Offset +10 , Screen.width * button_Size, Screen.height * 0.08f),"5", style)) {
			index = 5;
		}
		button_Offset += Screen.width * button_Size;
		if (GUI.Button (new Rect (width_Offset + button_Offset, height_Offset +10 , Screen.width * button_Size, Screen.height * 0.08f),"6", style)) {
			index = 6;
		}
		button_Offset += Screen.width * button_Size;
		if (GUI.Button (new Rect (width_Offset + button_Offset, height_Offset +10 , Screen.width * button_Size, Screen.height * 0.08f),"7", style)) {
			index = 7;
		}
		button_Offset += Screen.width * button_Size;
		if (GUI.Button (new Rect (width_Offset + button_Offset, height_Offset +10 , Screen.width * button_Size, Screen.height * 0.08f),"8", style)) {
			index = 8;
		}
		button_Offset += Screen.width * button_Size;
		if (GUI.Button (new Rect (width_Offset + button_Offset, height_Offset +10 , Screen.width * button_Size, Screen.height * 0.08f),"9", style)) {
			index = 9;
		}
		button_Offset += Screen.width * button_Size;
		if (GUI.Button (new Rect (width_Offset + button_Offset, height_Offset +10 , Screen.width * button_Size, Screen.height * 0.08f),"0", style)) {
			index = 0;
		}

		button_Offset += Screen.width * button_Size;
		if (GUI.Button (new Rect (width_Offset + button_Offset, height_Offset +10 , Screen.width * button_Size, Screen.height * 0.08f),"Menu "+ index, style)) {

		}
//----------------------------------------------------------------------------------------------------------------------------------------------------


		            }

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	void Update(){
		//int temp = 0;
		float axis = Input.GetAxis ("Mouse ScrollWheel"); //wheel scroll control
		if ((axis > 0) && (index < 9)) {
			index++;
		} else if ((axis > 0) && (index == 9)) {
			index = 0;
		} else if ((axis < 0) && (index > 0)) {
			index --;
		} else if ((axis < 0) && (index == 0)) {
			index = 9;
		}
//----------------------------------------------------------------------------------------------------------------------------------------------------
		if (Input.GetKey (KeyCode.Alpha1)) { //Key input control
			index = 1;
		} else if (Input.GetKey (KeyCode.Alpha2)) {
			index = 2;
		} else if (Input.GetKey (KeyCode.Alpha3)) {
			index = 3;
		} else if (Input.GetKey (KeyCode.Alpha4)) {
			index = 4;
		} else if (Input.GetKey (KeyCode.Alpha5)) {
			index = 5;
		} else if (Input.GetKey (KeyCode.Alpha6)) {
			index = 6;
		} else if (Input.GetKey (KeyCode.Alpha7)) {
			index = 7;
		} else if (Input.GetKey (KeyCode.Alpha8)) {
			index = 8;
		} else if (Input.GetKey (KeyCode.Alpha9)) {
			index = 9;
		} else if (Input.GetKey (KeyCode.Alpha0)) {
			index = 0;
		}
//----------------------------------------------------------------------------------------------------------------------------------------------------
	}
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


}

//=====================================================================================================================================================