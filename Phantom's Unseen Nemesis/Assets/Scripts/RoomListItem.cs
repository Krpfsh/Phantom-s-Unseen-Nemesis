using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RoomListItem : MonoBehaviour
{
    [SerializeField] private TMP_Text text;

    public RoomInfo _info;
    public void Setup(RoomInfo info)
    {
        _info = info;
        text.text = _info.Name;
    }
    public void OnClick()
    {
        Launcher.Instance.JoinRoom(_info);
    }
}
