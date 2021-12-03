using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager3Script : MonoBehaviour
{
    // [SerializeField] GameObject text;
    // [SerializeField] GameObject text2;
    // [SerializeField] GameObject cat;
    // [SerializeField] GameObject spaceObject;
    // private int count;
    // public float speed;
    // public int max_count;
    // void Start()
    // {
    //     // StartCoroutine("DisplayText");
    // }
    // IEnumerator DisplayText()
    // {
    //     spaceObject.SetActive(true);
    //     StartCoroutine(text.GetComponent<TextDisplayNoMoveScene>().TextDisplay(7));
    //     yield break;
    // }
    // public IEnumerator CatWalk()
    // {
    //     spaceObject.SetActive(false);
    //     count=0;
    //     while(count<max_count)
    //     {
    //         cat.transform.Translate(speed/50,0,0);
    //         yield return new WaitForSeconds(0.01f);
    //         count+=1;
    //     }
    //     yield return DisplayText2();
    // }
    // IEnumerator DisplayText2()
    // {
    //     spaceObject.SetActive(true);
    //     StartCoroutine(text2.GetComponent<TextDisplayNoMoveScene>().TextDisplay(8));
    //     yield break;
    // }
}
