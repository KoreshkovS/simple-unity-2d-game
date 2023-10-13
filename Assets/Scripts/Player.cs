using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthDisplay;
    [SerializeField] private TMP_Text _scoreDisplay;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private int _health = 8;

    private int _score;

    private void Start()
    {
        _scoreDisplay.text = $"Score: {_score}";
        _healthDisplay.text = "Health: " + _health;
    }

    private void Update()
    {
        transform.Rotate(Vector3.forward * _rotationSpeed * Input.GetAxisRaw("Horizontal") * Time.deltaTime);
    }

    public void TakeDamage()
    {
        _health--;
        _healthDisplay.text = "Health: " + _health;
        if (_health <= 0)
        {
            SceneManager.LoadScene("Game");
        }
    }

    public void AddScore()
    {
        _score++;
        _scoreDisplay.text = $"Score: {_score}";
    }
}
