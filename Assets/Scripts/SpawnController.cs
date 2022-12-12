using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pipePrefab;
    public float minY;
    public float maxY;
    public float x;
    public float interval;

    void Start()
    {
        InvokeRepeating("spawn",interval,interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawn()    {
        
        GameObject instance = Instantiate(pipePrefab);
        instance.transform.position=new Vector2(x, Random.Range(minY,maxY));
        instance.transform.SetParent(transform);
    }
}
