﻿using UnityEngine;

public class PathPoint : MonoBehaviour
{
    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, .25f);
    }
}
