using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
    // Quits the game on mouse click 
	public void OnMouseClick()
	{
		Application.Quit ();
	}

}

