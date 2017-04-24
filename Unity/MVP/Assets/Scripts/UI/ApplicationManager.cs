using UnityEngine;

public class ApplicationManager : MonoBehaviour {

    public GameObject menuPrefab;
    public GameObject gameUIPrefab;
    public GameObject gameplayPrefab;

    public GameObject playerController;

    public void Quit () 
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}

    public void Play()
    {
        menuPrefab.SetActive(false);
        gameplayPrefab.SetActive(true);
        playerController.SetActive(true);
    }

    public void BackMenu()
    {
        gameplayPrefab.SetActive(false);
        playerController.SetActive(false);
        menuPrefab.SetActive(true);
    }

    public void Retry()
    {
        gameUIPrefab.SetActive(false);
        gameplayPrefab.SetActive(true);
        playerController.SetActive(true);
    }

    public void EndGame()
    {
        gameplayPrefab.SetActive(false);
        playerController.SetActive(false);
        gameUIPrefab.SetActive(true);
    }
}
