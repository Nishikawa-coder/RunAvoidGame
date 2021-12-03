using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager4Script : MonoBehaviour
{
    // [SerializeField] GameObject text;
    // [SerializeField] GameObject text2;
    // [SerializeField] GameObject endtext;
    // [SerializeField] GameObject cat;
    // [SerializeField] GameObject player;
    // [SerializeField] GameObject spaceObject;
    // [SerializeField] GameObject heart;
    // public AudioSource endBGM;
    // public float[] speed;
    // public int[] max_counts;
    // private int count;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     FadeManageScript.FadeIn();
    //     cat.GetComponent<SpriteRenderer>().flipX = true;
    //     StartCoroutine("PlayerWalk");
    // }

    // public IEnumerator PlayerWalk()
    // {
    //     count=0;
    //     while(count<max_counts[0])
    //     {
    //         player.transform.Translate(speed[0]/50,0,0);
    //         yield return new WaitForSeconds(0.01f);
    //         count+=1;
    //     }
    //     yield return DisplayText();
    // }
    // IEnumerator DisplayText()
    // {
    //     spaceObject.SetActive(true);
    //     StartCoroutine(text.GetComponent<TextDisplayNoMoveScene>().TextDisplay(5));
    //     yield break;
    // }
    // public IEnumerator CatWalk()
    // {
    //     endBGM.Play();
    //     spaceObject.SetActive(false);
    //     count=0;
    //     while(count<max_counts[1])
    //     {
    //         cat.transform.Translate(speed[1]/50,0,0);
    //         yield return new WaitForSeconds(0.01f);
    //         count+=1;
    //     }
    //     yield return new WaitForSeconds(0.5f);
    //     yield return DisplayText2();
    // }
    // IEnumerator DisplayText2()
    // {
    //     spaceObject.SetActive(true);
    //     StartCoroutine(text2.GetComponent<TextDisplayNoMoveScene>().TextDisplay(6));
    //     yield break;
    // }
    // public IEnumerator PlayerWalk2()
    // {
    //     heart.SetActive(true);
    //     spaceObject.SetActive(false);
    //     yield return new WaitForSeconds(2f);
    //     count=0;
    //     while(count<max_counts[2])
    //     {
    //         player.transform.Translate(speed[2]/50,0,0);
    //         yield return new WaitForSeconds(0.01f);
    //         count+=1;
    //     }            
    //     yield return new WaitForSeconds(1f);
    //     count=0;
    //     while(count<max_counts[2])
    //     {
    //         player.transform.Translate(speed[2]/50,0,0);
    //         yield return new WaitForSeconds(0.01f);
    //         count+=1;
    //     }
    //     yield return new WaitForSeconds(3f);
    //     endtext.SetActive(true);
    //     yield break;
    // }
}
