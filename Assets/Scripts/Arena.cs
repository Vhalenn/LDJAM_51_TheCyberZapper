using UnityEngine;

public class Arena : MonoBehaviour
{
    public bool restingArena = false;

    [Header("Enemies")]
    public int minNumber;
    public int maxNumber;
    public int difficulty = 3;

    [Header("Spawn")]
    [SerializeField] Transform playerSpawn;
    [SerializeField] Transform enemiSpawn;
    [SerializeField] Transform collectibles;

    public void Activate()
    {
        
        for (int i = 0; i < collectibles.childCount; i++)
        {
            Transform t = collectibles.GetChild(i);
            if (!t) continue;
            t.gameObject.SetActive(true);
        }
        
    }

    public Transform GetPlayerSpawn()
    {
        return playerSpawn.GetChild(Random.Range(0, playerSpawn.childCount - 1));
    }

    public Transform GetEnemySpawn()
    {
        return enemiSpawn.GetChild(Random.Range(0, enemiSpawn.childCount - 1));
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1,0, 0.5f);
        Gizmos.DrawWireCube(transform.position, new Vector3(30f, 0.1f, 20f)); 
    }

}
