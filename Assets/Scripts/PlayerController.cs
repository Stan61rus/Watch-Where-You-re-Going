using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public bool hasPower;
    private Rigidbody playerRb;
    private GameObject focalPoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float inputForvard = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * inputForvard);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Powerup"))
        {
            hasPower = true;
            Destroy(other.gameObject);
        }
    }
}
