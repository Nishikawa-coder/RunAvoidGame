using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class LegSound : MonoBehaviour
{
    
    // private void OnCollisionExit(Collision collision)
    // {
    //     if(collision.gameObject.CompareTag("Floor"))
    //     {
    //         soundPlay=false;
    //     }
    // }
    // void OnCollisionStay(Collision collision)
    // {
    //     if(collision.gameObject.CompareTag("Floor"))
    //     {
    //         soundPlay=true;
    //     }
    // }

    // public AudioClip sound1;
    // AudioSource audioSource;
    // private bool soundPlay=true;    
    // void Start()
    // {
    //     audioSource = GetComponent<AudioSource>();
    //     StartCoroutine(PlayerSound(soundPlay));
    // }

    // IEnumerator PlayerSound(bool soundPlay)
    // {
    //     if(soundPlay){
    //     if (Input.GetKey("right"))
    //     {
    //         audioSource.Stop();
    //         audioSource.PlayOneShot(sound1);
    //     }
    //     else if (Input.GetKey("left"))
    //     {
    //         audioSource.Stop();
    //         audioSource.PlayOneShot(sound1);
    //     }
    //     else
    //     {
    //         audioSource.Stop();
    //     }
    //     yield return new WaitForSeconds(1f);
    //     yield return PlayerSound(soundPlay);
    //     }
    // }
    [SerializeField] AudioClip clip;
    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayFootstepSE()
    {
        source.PlayOneShot(clip);
    }
}
