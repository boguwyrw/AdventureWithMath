using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyLevels : MonoBehaviour
{
    Transform[] arithmeticOperations;

    void Start()
    {
        arithmeticOperations = new Transform[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            arithmeticOperations[i] = transform.GetChild(i);
        }

        Debug.Log(arithmeticOperations[1].gameObject.name);
        // Access to singleton GameManager
        Debug.Log(GameManager.Instance.name);
    }

    void Update()
    {
        
    }
}
