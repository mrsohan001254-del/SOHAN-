using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    [Header("Game Settings")]
    public bool isGameRunning = true;
    
    private float gameTime = 0f;
    private int collisionCount = 0;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    void Update()
    {
        if (isGameRunning)
        {
            gameTime += Time.deltaTime;
        }
        
        // Press C to change camera view
        if (Input.GetKeyDown(KeyCode.C))
        {
            CameraController camera = FindObjectOfType<CameraController>();
            if (camera != null)
            {
                camera.SwitchCameraView();
            }
        }
        
        // Press ESC to pause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isGameRunning = !isGameRunning;
            Time.timeScale = isGameRunning ? 1f : 0f;
        }
    }
    
    public float GetGameTime()
    {
        return gameTime;
    }
    
    public void OnCollision()
    {
        collisionCount++;
        Debug.Log("Collision Count: " + collisionCount);
    }
}