using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearScript : MonoBehaviour
{
    public float playerposition_x;
    [SerializeField] private GameObject foreverchaseObject;
    [SerializeField] private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        foreverchaseObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x>=playerposition_x)
        {
            foreverchaseObject.SetActive(true);
        }
    }
}
