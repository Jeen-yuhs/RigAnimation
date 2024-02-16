using UnityEngine;

public class PlayerController : MonoBehaviour
{    
    [SerializeField] private Animator _animator;
    [SerializeField] private float _speed;
    
    void Update()
    {
        CharacterMovement();
    }

    private void CharacterMovement()
    {
        float inputDir = Input.GetAxis("Horizontal");        

        _animator.SetFloat("Speed", Mathf.Abs(inputDir));

        transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + inputDir, transform.position.y, 0), Time.deltaTime * _speed);
               
    }
}
