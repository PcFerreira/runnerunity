using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Update is called once per frame
    public float Speed;

    void Start(){
        Destroy(gameObject, 2f);
    }

    void Update()
    {
        transform.Translate(Vector3.right * Speed * Time.deltaTime);
    }
}
