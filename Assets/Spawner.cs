using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Enemy EnemyPrefab;
    public float TimeToSpawn;
    public Transform[] Points;
    public float MainHP, IncreaseHP;

    private float timer;
    // Start is called before the first frame update
    private void Start()
    {
        timer = TimeToSpawn;
    }

    // Update is called once per frame
    private void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            Enemy enemy = Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
            enemy.Points = Points;
            enemy.SetHP(MainHP);

            MainHP += IncreaseHP;
            timer = TimeToSpawn;
        }
    }
}
