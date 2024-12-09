using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Room camera
    [SerializeField] private float speed;
    private float currentPosX;
    private Vector3 velocity = Vector3.zero;

    //Follow player
    [SerializeField] private Transform player;
    [SerializeField] private float aheadDistance;
    [SerializeField] private float cameraSpeed;
    private float lookAhead;

    [SerializeField] private float minX;
    [SerializeField] private float maxX;

    private void Update()
    {
        float targetPosX = Mathf.Clamp(currentPosX, minX, maxX);
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(targetPosX, transform.position.y, transform.position.z), ref velocity, speed);
    }


    public void MoveToNewRoom(Transform _newRoom)
    {
        print("here");
        currentPosX = _newRoom.position.x;
    }
}