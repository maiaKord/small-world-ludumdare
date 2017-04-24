using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningCondition : MonoBehaviour
{
    public ApplicationManager appManager;

    //public GameController gameController;
    //public GameObject triggerWin;
    //public GameObject fadeOutObj;
   // public GameObject playerController;

    void OnTriggerEnter(Collider col)
    {
        appManager.EndGame();

        //print("Ganaste");
        //fadeOutObj.SetActive(true);
        //playerController.SetActive(false);
    }

    void FadingOut()
    {

       
    }
}
