using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform previousRoom;
    [SerializeField] private Transform nextRoom;
    [SerializeField] private CameraController cam;

    private void Awake()
    {
        cam = Camera.main.GetComponent<CameraController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Room currentRoom = collision.transform.position.x < transform.position.x ? nextRoom.GetComponent<Room>() : previousRoom.GetComponent<Room>();
            Room otherRoom = collision.transform.position.x < transform.position.x ? previousRoom.GetComponent<Room>() : nextRoom.GetComponent<Room>();

            cam.MoveToNewRoom(currentRoom.transform);
            currentRoom.ActivateRoom(true);
            otherRoom.ActivateRoom(false);

            // Handle camera switching
            if (currentRoom.isBossRoom)
            {
                Camera.main.GetComponent<CameraFollow>().enabled = false;
                cam.enabled = true;
            }
            else
            {
                Camera.main.GetComponent<CameraFollow>().enabled = true;
                cam.enabled = false;
            }
        }
    }
}