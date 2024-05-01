using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{ 
    public float speed = 20f;

    Rigidbody rigidbody;

    [SerializeField] private GameObject Point;
    [SerializeField] private GameObject Ball;
    public int count = 0;
    //[SerializeField]
    //private float bounce = 10f;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, 0f);

        if (Input.GetKeyDown(KeyCode.Space) && count == 0)
        {
            // �e�𔭎˂���ꏊ���擾
            Vector3 bulletPosition = Point.transform.position;
            // ��Ŏ擾�����ꏊ�ɁA"bullet"��Prefab���o��������BBullet�̌�����Muzzle�̃��[�J���l�Ɠ����ɂ���i3�ڂ̈����j
            GameObject newBullet = Instantiate(Ball, bulletPosition, this.gameObject.transform.rotation);
            // �o���������e��up(Y������)���擾�iMuzzle�̃��[�J��Y�������̂��Ɓj
            Vector3 direction = newBullet.transform.up;
            // �e�̔��˕�����newBall��Y����(���[�J�����W)�����A�e�I�u�W�F�N�g��rigidbody�ɏՌ��͂�������
            newBullet.GetComponent<Rigidbody>().AddForce(direction * speed, ForceMode.Impulse);

            count++;
        }

    }
}