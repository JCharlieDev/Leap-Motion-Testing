using UnityEngine;

public class Grenade : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PrintInfo()
    {
        print(this);
    }

    public void DestroyWrapper()
    {
        Destroy(this.gameObject);
    }

    public void StartDestroyCountdown()
    {
        Invoke("DestroyWrapper", 3);
    }
}
