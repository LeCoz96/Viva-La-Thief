using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIData : MonoBehaviour
{
    [SerializeField] private int _aiLayerMask;
    public int GetAILayerMask() { return  _aiLayerMask; }

    [SerializeField] private float _detectionRange;
    public float GetDetectionRange() { return _detectionRange; }

    [SerializeField] private float _attackRange;
    public float GetAttackRange() { return _attackRange; }

    [SerializeField] private float _waypointRange;
    public float GetWaypointRange() { return _waypointRange; }
}
