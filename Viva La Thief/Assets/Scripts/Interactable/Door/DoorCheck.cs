using UnityEngine;

public class DoorCheck : MonoBehaviour
{
    [SerializeField] private GameObject _unlockObject;

    private Animator _animator;

    private bool _isOpen = false;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!_isOpen)
        {
            if (collision.gameObject.tag == "Player")
            {
                if (!_unlockObject.activeInHierarchy)
                {
                    _animator.SetTrigger("DoorOpen");
                    _isOpen = true;
                }
            }
        }
    }
}
