using ClientSocket;
using UnityEngine;

public class GameMenager : MonoBehaviour
{
    [SerializeField]
    private string ip;

    [SerializeField]
    private short port;


    private SocketClient socket;


    private void Awake()
    {
        socket = new SocketClient(ip, port);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
