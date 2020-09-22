using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3 : MonoBehaviour
{
    public Joint2D stage3Cup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D activator)
    {
        if(activator.tag == "Player")
        {
            stage3Cup.enabled = !stage3Cup.enabled;
        }
    }
}
