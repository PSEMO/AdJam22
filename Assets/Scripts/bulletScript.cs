using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    private float life = 2f;

    private void Awake()
    {
        Destroy(gameObject, life);
    }

    void Update()
    {
    }
}
