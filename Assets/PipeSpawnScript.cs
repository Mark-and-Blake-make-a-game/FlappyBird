using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        } else {
            timer = 0;
            spawnPipe();
        }
    }

    void spawnPipe() {
        float ceiling = transform.position.y + heightOffset;
        float floor = transform.position.y - heightOffset;
        Vector3 randomHeight = new Vector3(transform.position.x, Random.Range(floor, ceiling), 0);

        Instantiate(pipe, randomHeight, transform.rotation);
    }
}
