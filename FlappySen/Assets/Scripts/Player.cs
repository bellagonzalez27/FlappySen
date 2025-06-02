using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strength;
        }
        //if (Input.touchChount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);
        //}
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
}
