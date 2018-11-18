using UnityEngine;

public class Camera : MonoBehaviour
{
    float Speed = 5.0f;
    int Boundary = 1;
    int Width;
    int Height;

    void Start()
    {
        Width = Screen.width;
        Height = Screen.height;

    }

    void Update()
    {
        if (Input.mousePosition.x > Width - Boundary)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * Speed,
                                       0.0f, 0.0f);
        }

        if (Input.mousePosition.x < 0 + Boundary)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * Speed,
                                       0.0f, 0.0f);
        }

        if (Input.mousePosition.y > Height - Boundary)
        {
            transform.position += new Vector3(0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * Speed, 0.0f);
        }

        if (Input.mousePosition.y < 0 + Boundary)
        {
            transform.position += new Vector3(0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * Speed, 0.0f);
        }
    }
}
 