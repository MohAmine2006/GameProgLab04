using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    void Start()
    {
        // Destroy the bullet after a few seconds
        Destroy(gameObject, 5f);
    }
}
