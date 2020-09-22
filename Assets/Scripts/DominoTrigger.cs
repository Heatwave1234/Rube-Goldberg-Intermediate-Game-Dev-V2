using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoTrigger : MonoBehaviour
{
    public GameObject marble;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        marble.SetActive(true);
    }
}
