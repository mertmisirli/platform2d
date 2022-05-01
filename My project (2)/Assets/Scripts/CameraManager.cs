using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public Transform target;

    public float cameraSpeed;


    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector3.Slerp(transform.position, new Vector3(target.position.x, target.position.y, transform.position.z), cameraSpeed);
    }
}
