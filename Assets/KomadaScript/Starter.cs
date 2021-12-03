using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    public Speak speak;
    // Start is called before the first frame update
    void Start()
    {
        speak.speak();
    }

}
