using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkScript : MonoBehaviour
{
    [SerializeField] GameObject cat;
    // [SerializeField] GameObject player;
    public float speed = -60;
    public int max_count=500;
    private int count;
    public void Start()
    {
        StartCoroutine(CatWalk());
    }
    IEnumerator CatWalk()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("CatWalk!");
        while(count<max_count)
        {
            cat.transform.Translate(speed/500,0,0);
            count+=1;
        }
    }
    
}
