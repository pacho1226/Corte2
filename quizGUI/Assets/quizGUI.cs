using UnityEngine;
using System.Collections;
using System;

public class quizGUI : MonoBehaviour {


	private string textArea ="";
	private string text="";

	private string textArea2 ="";
	private string text2="";



	void OnGUI()
	{




		GUI.Label(new Rect (230, 80, 200, 30), "ACTIVIDADES");
		text = GUI.TextField (new Rect (100,120, 370, 30), text,100);
		textArea = GUI.TextArea (new Rect (270, 170, 200, 300), textArea,100);

		//GUI.Label (new Rect (700, 200, 100, 100), "text area"+text);

		if(GUI.Button(new Rect (100,170, 150, 80), "Ingresar actividades"))
		{


			textArea=text+"\n"+textArea;

			text="";

		}
		if (GUI.Button (new Rect (100, 280, 150, 80), "BORRAR")) {
			textArea="";	
		}




		GUI.Label(new Rect (730, 80, 200, 30), "TAREAS");
		text2 = GUI.TextField (new Rect (600,120, 370, 30), text2,100);
		textArea2 = GUI.TextArea (new Rect (770, 170, 200, 300), textArea2,100);
		
		//GUI.Label (new Rect (700, 200, 100, 100), "text area"+text);
		
		if(GUI.Button(new Rect (600,170, 150, 80), "Ingresar tarea"))
		{
			textArea2=textArea2+"\n"+text2;
			text2="";

		}
		if (GUI.Button (new Rect (600, 280, 150, 80), "BORRAR")) {
			textArea2="";	
		}


			

	}
}
