using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("MoveInfo")]
    public float MoveSpeed { get; private set; }
    public PlayerStateMachine PlayerStateMachine { get; private set; }

    public Rigidbody2D Rigidbody;

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        PlayerStateMachine = new PlayerStateMachine();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
