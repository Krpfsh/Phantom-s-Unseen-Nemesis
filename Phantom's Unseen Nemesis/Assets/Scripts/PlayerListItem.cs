using Photon.Pun;
using TMPro;
using UnityEngine;
using Photon.Realtime;

public class PlayerListItem : MonoBehaviourPunCallbacks
{
    [SerializeField] private TMP_Text text;
    private Player _player;
    public void Setup(Player player)
    {
        _player = player;
        text.text = _player.NickName;
    }
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        if(_player == otherPlayer)
        {
            Destroy(gameObject);
        }
    }
    public override void OnLeftRoom()
    {
        Destroy(gameObject);
    }
}
