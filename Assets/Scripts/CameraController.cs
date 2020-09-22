using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform cameraTransform;
    public Transform ballTransform;
    // Start is called before the first frame update
    void Start()
    {
        ballTransform = this.gameObject.transform;
        
    }

    // Update is called once per frame
    void Update()
    {

        cameraTransform.position = ballTransform.position + new Vector3(-5f, 2f, -15f);


    }
}
