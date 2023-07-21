using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Node _rootNodel;

    void Start()
    {
        BuildBehaviourTree();
    }

    void Update()
    {
        _rootNodel.Decision();
    }

    private void BuildBehaviourTree()
    {

    }
}
