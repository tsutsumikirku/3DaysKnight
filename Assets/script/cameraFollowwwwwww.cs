using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowwwwwww : MonoBehaviour
{
    // プレイヤーのTransform
    public Transform player;

    // カメラとプレイヤーのオフセット
    public Vector3 offset;

    void Update()
    {
        // カメラの位置をプレイヤーの位置にオフセットを加えて設定
        if (player != null)
        {
            transform.position = player.position + offset;
        }
    }
}
