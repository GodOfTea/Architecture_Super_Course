using UnityEngine;

public class Coin : MonoBehaviour
{
    public void SetToPosition(Transform spawnPoint)
    {
        transform.parent = spawnPoint;
        transform.position = spawnPoint.position;
    }
}
