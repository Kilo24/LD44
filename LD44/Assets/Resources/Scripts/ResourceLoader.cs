using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is used to conveniently store references to dynamically loaded resources. Use this
/// when you need references to prefabs but don't have a place in the Unity inspector to assign it.
/// </summary>
/// <typeparam name="ResourceLoader"></typeparam>
public class ResourceLoader : Singleton<ResourceLoader>
{
    [HideInInspector] public GameObject examplePrefab;

    // Use this for initialization
    protected override void Awake()
    {
        base.Awake();

        LoadResources();
    }

    private void LoadResources()
    {
        //examplePrefab = Resources.Load("Prefabs/Example") as GameObject;
    }
}
