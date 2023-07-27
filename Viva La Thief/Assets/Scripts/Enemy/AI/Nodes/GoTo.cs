using UnityEngine;

public class GoTo : Node
{
    private EnemyAI _ai;
    private AIActions _actions;
    private GameObject _target;
    private float _range;

    public GoTo(EnemyAI ai, AIActions actions, GameObject target, float range)
    {
        _ai = ai;
        _actions = actions;
        _target = target;
        _range = range;
    }

    public override NodeState Decision()
    {
        if (_target != null)
        {
            float distance = Vector3.Distance(_target.transform.position, _ai.transform.position);

            if (distance > _range)
            {
                //_actions.MoveTo(_target.transform.position);
                return NodeState.RUNNING;
            }
            else
                return NodeState.SUCCESS;
        }
        else
            return NodeState.FAILURE;
    }
}
