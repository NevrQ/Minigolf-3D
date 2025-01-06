using UnityEngine;

public class Vortex : MonoBehaviour
{
    private Collider VortexCollider;

    public float VortexForce;

    private void Awake()
    {
        VortexCollider = GetComponent<Collider>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Vector3 normal = other.transform.position - VortexCollider.bounds.center;
            other.attachedRigidbody.AddForce(normal * VortexForce);
        }
    }
}
