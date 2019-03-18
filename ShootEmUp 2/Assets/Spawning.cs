using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public List<Enemy> enemyTypes = new List<Enemy>();
    public BackgroundElement bgElement;
    private float spawnCooldown = 3.0f;
    private float timeStamp;
    private int numEnemies;
    private Random rnd = new Random();

    // Start is called before the first frame update
    private void Start()
    {
        timeStamp = Time.time;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timeStamp <= Time.time) {
            if (Random.Range(0,5) >= 3) {
                spawnBackgroundElement();
            }

            spawnEnemyGroup();
            
            timeStamp = Time.time + spawnCooldown;
        }
    }
    void spawnBackgroundElement()
    {
        Instantiate(bgElement, new Vector3(this.transform.position.x + 20.0f + Random.Range(-5.0f, 5.0f), 0.0f + Random.Range(-5.0f, 5.0f), 0.0f), Quaternion.identity);
    }

    void spawnEnemyGroup()
    {
        numEnemies = Random.Range(1, 4);
        for (int i = 0; i < numEnemies; i++) {
            spawnEnemy();
        }
    }

    void spawnEnemy()
    {
        Enemy newEnemy = enemyTypes[Random.Range(0, enemyTypes.Count)];
        Instantiate(newEnemy, new Vector3(this.transform.position.x + 25.0f + Random.Range(-5.0f, 5.0f), 0.0f + Random.Range(-5.0f, 5.0f), 0.0f), Quaternion.identity);
    }
}
