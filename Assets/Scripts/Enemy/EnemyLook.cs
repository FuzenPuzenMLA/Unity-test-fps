using UnityEngine;

public class EnemyLook : MonoBehaviour
{
    [SerializeField] private EnemyServer enemyServer;
    private Transform player;

    private void Start()
    {
        player = enemyServer.GetPlayer();
    }

    private void Update()
    {
        transform.LookAt(player); // весьма топорно конечно, но для условия задачи подойдёт
    }
}
