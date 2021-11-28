using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkScript : MonoBehaviour
{
    [SerializeField] GameObject cat;
    [SerializeField] GameObject player;
    [SerializeField] GameObject maincamera;
    public float speed = -60;
    public int[] max_counts;
    private int count;
    void Start()
    {
        
    }
    public void StartEvent()
    {
        StartCoroutine(CatWalk());
    }
    IEnumerator CatWalk()
    {
        count=0;
        yield return new WaitForSeconds(1f);
        while(count<max_counts[0])
        {
            cat.transform.Translate(speed/300,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        yield return PlayerWalkwithCamera();
    }
    IEnumerator PlayerWalkwithCamera()
    {
        // Debug.Log("playerwalk");
        count=0;
        while(count<max_counts[1])
        {
            player.transform.Translate(speed/5,0,0);
            maincamera.transform.Translate(speed/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        yield return Camera();
    }
    IEnumerator Camera()
    {
        yield return new WaitForSeconds(1f);
        count=0;
        while(count<max_counts[1])
        {
            maincamera.transform.Translate(speed/400,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
    }
}
