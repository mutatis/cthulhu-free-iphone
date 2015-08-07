﻿// Auto destruct script that can be added to the root particle system
// of a particle effect. It will destroy the gameobject and its children.

using UnityEngine;
public class AutoDestructNotVisible : MonoBehaviour
{
	void OnBecameInvisible()
    {
        PoolManager.Pools["fx"].Despawn(transform);
    }
}