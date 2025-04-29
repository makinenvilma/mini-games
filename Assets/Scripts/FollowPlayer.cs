using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float offsetX = 2f;

    void Update()
    {
        transform.position = new Vector3(player.position.x + offsetX, 0, -10);
    }
}
