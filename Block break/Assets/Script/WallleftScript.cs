using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallleftScript : MonoBehaviour
{
    [SerializeField]
    private float bounce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // �������������Rigidbody��x�������ɗ͂�������B
        // �����x���̃}�C�i�X�����ɗ͂������Ē��˕Ԃ��B
        collision.rigidbody.AddForce(bounce, 0f, 0f, ForceMode.Impulse);
    }
}
