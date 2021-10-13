using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //reference to player movement script
    public PlayerMovement player;
    public GameObject playerObject;
    public GameObject playerStart;

    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //call movement every frame and send axis data
        player.MoveHorizontal(Input.GetAxis("Horizontal"));
        player.MoveVertical(Input.GetAxis("Vertical"));
        if(Input.GetKeyDown(KeyCode.R))
        {
            playerObject.transform.position = playerStart.transform.position;
        }
    }
}
