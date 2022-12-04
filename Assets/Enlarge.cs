using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enlarge : MonoBehaviour
{

    public Vector3 expTime;
    public GameObject CameraRoot;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        expTime = new Vector3(0.1f, 0.1f, 0.1f);

        this.transform.localScale = transform.localScale + expTime;

        if (Time.fixedTime >= 2)
        {
            CameraRoot.transform.localPosition += new Vector3(0f, 0.25f, -0.25f);
        }


    }
}
