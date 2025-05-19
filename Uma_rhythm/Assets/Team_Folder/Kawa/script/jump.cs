using UnityEngine;

public class jump : MonoBehaviour
{
    public float jumpForce = 5f;
    public float minInterval = 1f;
    public float maxInterval = 3f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(JumpRandomly());
    }

    System.Collections.IEnumerator JumpRandomly()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minInterval, maxInterval));
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}