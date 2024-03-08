using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UsernameDisplay : MonoBehaviour
{
    [SerializeField] private PhotonView playerPV;
    [SerializeField] private TMP_Text text;

    private void Start()
    {
        if (playerPV.IsMine)
        {
            gameObject.SetActive(false);
        }
        text.text = playerPV.Owner.NickName;
    }
}
