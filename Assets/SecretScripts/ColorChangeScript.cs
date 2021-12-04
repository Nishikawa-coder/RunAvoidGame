using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChangeScript : MonoBehaviour
{
    void Start()
    {
        // this.color = new Color(0.0f, 0.0f, 0.0f, 0.0f);
    }
    // MeshRenderer mesh;

    // void Start ()
    // {
    // mesh = GetComponent<MeshRenderer>();
    // mesh.material.color = mesh.material.color - new Color32(0,0,0,0);
    // StartCoroutine("Transparent");
    // }

    // IEnumerator Transparent()
    // {
    //     for ( int i = 0 ; i < 255 ; i++ ){
    //         mesh.material.color = mesh.material.color - new Color32(0,0,0,1);
    //         Debug.Log(mesh.material.color);
    //         yield return new WaitForSeconds(0.01f);
    //     }
    // }
}
