using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowwwwwww : MonoBehaviour
{
    // �v���C���[��Transform
    public Transform player;

    // �J�����ƃv���C���[�̃I�t�Z�b�g
    public Vector3 offset;

    void Update()
    {
        // �J�����̈ʒu���v���C���[�̈ʒu�ɃI�t�Z�b�g�������Đݒ�
        if (player != null)
        {
            transform.position = player.position + offset;
        }
    }
}
