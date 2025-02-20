using UnityEngine;

public class Ememy : MonoBehaviour
{
    private Rigidbody enemyRb;
    private GameObject player;
    private float speed = 3.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        enemyRb.AddForce((player.transform.position - transform.position).normalized * speed);
    }
}
