using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchCatScript : MonoBehaviour
{
    [SerializeField] GameObject targetObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = (targetObject.transform.position - this.transform.position).normalized;
        this.GetComponent<SpriteRenderer>().flipX = (dir.x< 0);
    }
}
