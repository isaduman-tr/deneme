// 24.01.2025 AI-Tag
// This was created with assistance from Muse, a Unity Artificial Intelligence product

using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public float speed = 5.0f; // Speed of the player movement

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;

        // Check for input and adjust movement
        if (Input.GetKey(KeyCode.W))
        {
            move += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            move += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            move += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            move += Vector3.right;
        }

        // Move the player
        transform.Translate(move * speed * Time.deltaTime);
    }
}