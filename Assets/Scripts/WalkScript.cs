using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkScript : MonoBehaviour
{
    [SerializeField] GameObject cat;
    [SerializeField] GameObject player;
    [SerializeField] GameObject maincamera;
    public float[] speed;
    public int[] max_counts;
    private int count;
    void Start()
    {
        
    }
    public void StartEvent()
    {
        StartCoroutine("CatWalk");
    }
    IEnumerator CatWalk()
    {
        Debug.Log("catwalk");
        count=0;
        yield return new WaitForSeconds(1f);
        while(count<max_counts[0])
        {
            cat.transform.Translate(speed[0]/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        yield return PlayerWalkwithCamera();
    }
    IEnumerator PlayerWalkwithCamera()
    {
        Debug.Log("playerwalk");
        count=0;
        while(count<max_counts[1])
        {
            player.transform.Translate(speed[1]/50,0,0);
            maincamera.transform.Translate(speed[2]/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        yield return Camera();
    }
    IEnumerator Camera()
    {
        Debug.Log("camera");
        yield return new WaitForSeconds(1f);
        count=0;
        while(count<max_counts[2])
        {
            maincamera.transform.Translate(speed[3]/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
    }
}
