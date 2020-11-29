using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 20f;
    public float panBorderThickness = 10f;

    public float scrollSpeeed = 20f;

    public bool rotateAround = true;
    public float rotationSpeed = 5f;
    

    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            pos.z += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            pos.z -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.mousePosition.y <= panBorderThickness)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }
       

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollSpeeed *100f* Time.deltaTime;


        transform.position = pos;
    }
}
