using UnityEngine;

public class RoomTrigger : MonoBehaviour
{
    public int roomDesign;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            PlayerTracker tracker = other.GetComponent<PlayerTracker>();
            if (tracker != null)
            {
                tracker.roomDesign = roomDesign;
            }
        }
    }
}