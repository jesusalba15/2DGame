using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScenes : MonoBehaviour
{
    public Timer timer; 

    public void LoadScene(string sceneName)
    {
        if (timer != null)
        {
            timer.TimerStop();  
            GameManager.Instance.SumaTimeGlobal(timer.GetCurrentTime());
        }

        SceneManager.LoadScene(sceneName);
    }
}