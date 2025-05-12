using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    [SerializeField] int speed = 6;
    [SerializeField] int num = 0;
    Renderer rend;
    private float alfa = 0;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!(rend.material.color.a <= 0))
        {
            rend.material.color = new Color(rend.material.color.r, rend.material.color.r, rend.material.color.r, alfa);
        }

        if (Input.GetKeyDown("up") ||
            Input.GetKeyDown("down") ||
            Input.GetKeyDown("left") ||
            Input.GetKeyDown("right")||
            Input.GetKeyDown(KeyCode.Space))
        {
            color_change();
        }

        alfa -= speed * Time.deltaTime;
    }

    private void color_change()
    {
        alfa = 1.0f;
        rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, alfa);
    }
}
