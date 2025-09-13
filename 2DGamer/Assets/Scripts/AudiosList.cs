using UnityEngine;
using System.Collections.Generic;


public class AudiosList : MonoBehaviour
{
    public List<AudioClip> listClips = new List<AudioClip>();
    public AudioSource audioSource;

    [SerializeField] private bool loopPlayList = true;
    private int currentIndex = -1;
   
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void PlayNext()
    {
        if ((listClips == null || listClips.Count == 0) || audioSource == null) return;

        currentIndex++;

        if (currentIndex >= listClips.Count)
        {
            if (loopPlayList == true)
            {
                currentIndex = 0;
            }
            else
            {
                currentIndex = listClips.Count - 1;
                return;
            }
        }
        audioSource.Stop();
        audioSource.clip = listClips[currentIndex];
        audioSource.Play();
    }
}
