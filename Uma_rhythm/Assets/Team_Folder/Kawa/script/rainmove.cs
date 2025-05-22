using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rainmove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Time.deltaTime * 10, 0,0);

        if(transform.position.x<=10)
        {
           // Destroy(gameObject);
            Debug.Log("a");
        }

        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);

        if (viewPos.x < 0 || viewPos.x > 1 || viewPos.y < 0 || viewPos.y > 1)
        {
            Destroy(gameObject);
        }
    }


}

