using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextWave : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;
    [SerializeField] private Button _nextWaveButton;

    private void OnEnable()
    {
        _spawner.AllEnemiesSpawned += OnAllEnemiesSpawned;
        _nextWaveButton.onClick.AddListener(OnNextButtonClick);
    }

    private void OnDisable()
    {
        _spawner.AllEnemiesSpawned -= OnAllEnemiesSpawned;
        _nextWaveButton.onClick.RemoveListener(OnNextButtonClick);
    }

    public void OnAllEnemiesSpawned()
    {
        _nextWaveButton.gameObject.SetActive(true);
    }

    public void OnNextButtonClick()
    {
        _spawner.NextWave();
        _nextWaveButton.gameObject.SetActive(false);
    }
}
