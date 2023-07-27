using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

enum States
{
    Patrol,
    Wait,
    Aggro
}

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private bool _isWaitAI;
    [SerializeField] private List<GameObject> _waypoints = new List<GameObject>();

    private int _currentWaypoint;

    private Node _rootNodel;

    private EnemyAI _ai;
    private AIData _data;
    private AIActions _actions;

    private States _state;

    private GameObject GetCurrentWaypoint() { return _waypoints[_currentWaypoint]; }

    void Start()
    {
        _ai = GetComponent<EnemyAI>();

        BuildBehaviourTree();
    }

    void Update()
    {
        _rootNodel.Decision();
    }

    private void BuildBehaviourTree()
    {
        #region Nodes

        GoTo goToNextWaypoint = new GoTo(_ai, _actions, GetCurrentWaypoint(), _data.GetWaypointRange());


        #endregion


    }
}
