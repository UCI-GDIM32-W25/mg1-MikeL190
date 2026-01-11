using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        // 1. Get input from the keyboard
        // "Horizontal" handles A, D, Left Arrow, Right Arrow
        // "Vertical" handles W, S, Up Arrow, Down Arrow
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // 2. Create a direction vector (where to move)
        Vector3 direction = new Vector3(moveX, moveY, 0);

        // 3. Apply the movement
        // We multiply by Time.deltaTime so it moves at the same speed on all computers
        _playerTransform.position += direction * _speed * Time.deltaTime;

        // Check if the Space bar was pressed this frame
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_numSeedsLeft > 0)
            {
                PlantSeed();
            }
            else
            {
                Debug.Log("No more seeds");
            }
        }
    }

    [ContextMenu("Plant Seeds Now")]
    public void PlantSeed ()
    {
        GameObject plant = Instantiate(_plantPrefab, transform.position, Quaternion.identity) as GameObject;
        _numSeedsLeft--;
        _numSeedsPlanted++;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);

        Debug.Log("You have planted seeds");
    }
}
