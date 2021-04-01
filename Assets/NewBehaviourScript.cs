using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(4.2f, 2.5f, 11f);
        transform.localEulerAngles = new Vector3(-31f, -27f, 33f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
