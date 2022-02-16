using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    CollisionItem[] collisionItems;

    private void Start()
    {
        collisionItems = FindObjectsOfType<CollisionItem>();
        int index = 0;
        foreach (var item in collisionItems)
        {
            item.IdIndex = index++;
        }
    }

    private void LateUpdate()
    {
        // todo �������ͻȻ�����٣���֮ǰcollisionStay�������޷���⵽
        int length = collisionItems.Length;
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                var item1 = collisionItems[i];
                var item2 = collisionItems[j];
                if (item1 != item2)
                {
                    item1.CheckCollision(item2);
                }
            }
        }
    }
}
