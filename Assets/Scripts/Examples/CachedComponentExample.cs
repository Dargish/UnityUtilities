using UnityEngine;

public class CachedComponentExample : MonoBehaviour
{
    public GameObject target;

    CachedComponent<Rigidbody> targetRigidbody;

    void Start()
    {
        targetRigidbody = new CachedComponent<Rigidbody>(target);
    }

    void Update()
    {
        if (targetRigidbody.get() != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                targetRigidbody.get().AddForce(Vector3.up * 300.0f);
            }
        }
    }
}
