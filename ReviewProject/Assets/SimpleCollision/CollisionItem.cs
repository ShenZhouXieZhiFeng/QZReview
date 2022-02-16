using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ECollisionType
{ 
    AABB,
    OBB
}

public class CollisionItem : MonoBehaviour
{
    public int IdIndex;

    public ECollisionType ColType;

    [Header("±ß³¤")]
    public float SideLength = 10;

    [Header("Debug")]
    public bool DrawDebug = false;

    public Vector3 Min
    {
        get
        {
            var originPos = transform.position;
            originPos.x -= SideLength / 2;
            originPos.z -= SideLength / 2;
            return originPos;
        }
    }

    public Vector3 Max
    {
        get
        {
            var originPos = transform.position;
            originPos.x += SideLength / 2;
            originPos.z += SideLength / 2;
            return originPos;
        }
    }

    CollisionEvents[] eventComps;

    private void Start()
    {
        eventComps = GetComponents<CollisionEvents>();
    }

    private void Update()
    {
        if (DrawDebug)
        {
            float offset = 0.6f;
            Vector3 pos0 = Min + new Vector3(0, offset, 0);
            Vector3 pos1 = Min + new Vector3(0, offset, SideLength);
            Vector3 pos2 = Max + new Vector3(0, offset, 0);
            Vector3 pos3 = Min + new Vector3(SideLength, offset, 0);
            Debug.DrawLine(pos0, pos1, Color.blue);
            Debug.DrawLine(pos1, pos2, Color.blue);
            Debug.DrawLine(pos2, pos3, Color.blue);
            Debug.DrawLine(pos3, pos0, Color.blue);
        }
    }

    public void CheckCollision(CollisionItem other)
    {
        bool res = isIntersect(other);

       
    }

    bool isIntersect(CollisionItem other)
    {
        bool res = true;

        var thisMin = Min;
        var thisMax = Max;
        var otherMin = other.Min;
        var otherMax = other.Max;

        if (thisMax.x < otherMin.x && thisMax.z < otherMin.z)
        {
            res = false;
        }
        else if (thisMin.x > otherMax.x && thisMin.z > otherMax.z)
        {
            res = false;
        }
        else
        { 
            
        }

        return res;
    }
}
