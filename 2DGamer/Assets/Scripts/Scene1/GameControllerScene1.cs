using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour

    
{

    public Timer tiempoEscena;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    {
        GameManager.Instance.SumaTimeGlobal(0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
