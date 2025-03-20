using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Vector3 velocity, spin;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //kick
            Kick();
        }
        ApplyMagnusEffect();
    }

    void Kick()
    {
        rb.linearVelocity = velocity;
        rb.angularVelocity = spin;
    }

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity, rb.angularVelocity);
        
        rb.AddForce(magnusForce);
    }
}
