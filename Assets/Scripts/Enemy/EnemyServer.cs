using UnityEngine;

public class EnemyServer : MonoBehaviour
{
    // Обычно такие начальные значения как обьект игрока передаются при спавне через спавнер(как это сделано с пулей)
    // за отсутствием такого подключим всех врагов на сцене к нашему серверу для поиска игрока
    // это в любом случае "дешевше" чем использовать GameObject.FindGameObjectWithTag("Player")
    [SerializeField] private Transform player;
    
    public Transform GetPlayer()
    {
        return player;
    }
}
