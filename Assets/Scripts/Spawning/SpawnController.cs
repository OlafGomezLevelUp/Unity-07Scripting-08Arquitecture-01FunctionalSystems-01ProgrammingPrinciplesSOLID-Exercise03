using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField]
    List<GameObject> enemies = new List<GameObject>();

    [SerializeField]
    float spawningRate;

    
    
    SpawningBehaviour spawningBehaviour;

    

    private void Awake() {
        spawningBehaviour = GetComponent<SpawningBehaviour>();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DoCreateEnemy());
    }

    IEnumerator DoCreateEnemy()
    {
        var _selection = Random.Range(0, enemies.Count);
        float lastSpawn = 0;

        while (spawningRate >  lastSpawn)
        {
            lastSpawn += Time.deltaTime;
            
            yield return null;
        }

        GameObject _go = spawningBehaviour.SpawnObject(enemies[_selection]);
        StartCoroutine(DoCreateEnemy());
    }
}
