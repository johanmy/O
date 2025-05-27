using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
class Circle : MonoBehaviour
{
    void Start()
    {
        Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
        rigidbody2D.gravityScale = 0;
    }
}