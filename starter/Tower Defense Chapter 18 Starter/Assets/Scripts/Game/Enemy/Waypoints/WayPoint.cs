using System.Collections;
using UnityEngine;
using System.Collections.Generic;
public class WayPoint : MonoBehaviour
{

    public static WayPoint Instance;

    public List<Path> Paths = new List<Path>();
    void Awake()
    {
  
        Instance = this;
    }

    public Vector3 GetSpawnPosition(int pathIndex)
    {
        return Paths[pathIndex].WayPoints[0].position;
    }
}

[System.Serializable]
public class Path
{
    public List<Transform> WayPoints = new List<Transform>();
}