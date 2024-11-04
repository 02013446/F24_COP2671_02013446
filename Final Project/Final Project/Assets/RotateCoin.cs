using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float rotationSpeed = 100f; // Speed of rotation

    void Update()
    {
        // Rotate the coin around its Y-axis at the specified speed
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
