using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningCondition : MonoBehaviour {
	public GameObject triggerWin;
    public GameObject fadeOutObj;
    public GameObject playerController;

    void OnTriggerEnter(Collider col)
    {
        print("Ganaste");
        fadeOutObj.SetActive(true);
        playerController.SetActive(false);
    }

    void FadingOut()
    {

       
    }
}
