using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class NewBehaviourScript : Editor
{
    [MenuItem("test/RenameGameobject")]
    public static void RenameGameObject()
    {
        GameObject seletedGameobject = Selection.activeGameObject;
        
        Transform[] a =seletedGameobject.transform.GetComponentsInChildren<Transform>();
        int i = 0;
        foreach (var item in a )
        {
            if(item.name != "don")
            {
                item.name = i.ToString();
               
            }
            i++;
        }

    }
    [MenuItem("test/bOXcOL")]
    public static void bOX()
    {
        GameObject seletedGameobject = Selection.activeGameObject;
        
        Transform[] a =seletedGameobject.transform.GetComponentsInChildren<Transform>();
        foreach (var item in a )
        {
            if(item.GetComponent<MeshCollider>())
            {
                DestroyImmediate(item.GetComponent<MeshCollider>());
                item.gameObject.AddComponent<BoxCollider>();
            }
        }

    }
}
