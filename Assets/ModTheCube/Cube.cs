using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    public float speed;

    void Start()
    {
        transform.position = new Vector3(RandomInt()/100, RandomInt()/100, RandomInt()/100);
        transform.localScale = Vector3.one * RandomInt()/RandomInt();
        
        Material material = Renderer.material;

        speed = RandomInt();

        material.color = new Color(RandomInt()/255, RandomInt()/255, RandomInt()/255, RandomInt()/255);
    }
    
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, speed * Time.deltaTime, 0.0f);
    }

    float RandomInt()
    {
        return Random.Range(0, 255);
    }
}
