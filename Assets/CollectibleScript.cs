using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    [SerializeField] GameObject screen;
    //[SerializeField] Vi
    [SerializeField] AudioSource screenAudio;
    [SerializeField] string videoName;
    [SerializeField] AudioClip audioFile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Altaar"))
        {
            screenAudio.clip = audioFile;
            screenAudio.PlayOneShot(screenAudio.clip);
        }
    }
}
