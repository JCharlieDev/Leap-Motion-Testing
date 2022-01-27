using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

public class TestingUnityEvents : MonoBehaviour
{
    // Start is called before the first frame update
    public void PrintGreetMsg(GameObject g)
    {
        print("PrintGreenMsg called with object " + g);
    }

    public void PrintGreetMsgV2(IInteractionBehaviour b)
    {
        print("PrintGreenMsgV2 called with object " + b);
    }
}
