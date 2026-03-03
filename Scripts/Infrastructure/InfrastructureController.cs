// Main Dependencies
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

// Game Dependencies
using AsTheBellTolls.Infrastructure.Core;

namespace AsTheBellTolls.Infrastructure {
public class InfrastructureController : Singleton<InfrastructureController> {

#region -------------------- Serialized Variables --------------------
    [Header("Sub Controllers")]
    [SerializeField] private AdminSubController _adminSubController;
    [SerializeField] private CoreSubController _coreSubController;
    [SerializeField] private EventsSubController _eventsSubController;
    [SerializeField] private GameTimeSubController _gameTimeSubController;
    [SerializeField] private PlatformSubController _platformSubController;
    [SerializeField] private SaveSubController _saveSubController;
    [SerializeField] private SettingsSubController _settingsSubController;
#endregion
#region -------------------- Public Variables --------------------
    public AdminSubController Admin => _adminSubController;
    public CoreSubController Core => _coreSubController;
    public EventsSubController Events => _eventsSubController;
    public GameTimeSubController GameTime => _gameTimeSubController;
    public PlatformSubController Platform => _platformSubController;
    public SaveSubController Save => _saveSubController;
    public SettingsSubController Settings => _settingsSubController;
#endregion
#region -------------------- Private Variables --------------------
    void Start()
    {
	    // // FOR TESTING
	    // PlayerPrefs.DeleteAll();
	    // PlayerPrefs.Save();
	    // // FOR TESTING
	    
        _coreSubController.IsLoaded = false;
        SceneManager.LoadSceneAsync(_coreSubController.Scene_Main00, LoadSceneMode.Single);
    }
#endregion
#region -------------------- Initial Functions --------------------
    
#endregion
#region -------------------- Coroutines --------------------
    
#endregion
#region -------------------- Public Methods --------------------
    public void Initialize()
    {
        WriteLog(this.GetType().Name, $"Initializing the controller.");

        _adminSubController.Initialize();
        _coreSubController.Initialize();
        _eventsSubController.Initialize();
        _gameTimeSubController.Initialize();
        _platformSubController.Initialize();
        _saveSubController.Initialize();
        _settingsSubController.Initialize();

        LoadingStepCompleted();
    }
    
    public void LoadingStepCompleted()
	{
		WriteLog(this.GetType().Name, $"Loading step has completed.");
        _coreSubController.LoadingStepCompleted();
	}

    public void WriteLog(string fileName, string content)
    {
        _coreSubController.WriteLog(fileName, content);
    }

	public void WriteError(string fileName, string content)
	{
        _coreSubController.WriteError(fileName, content);
    }

	public void ChangeScene(string sceneName)
	{
		WriteLog(this.GetType().Name, $"Changing the scene to {sceneName}.");
		_coreSubController.ChangeScene(sceneName);
	}
#endregion
#region -------------------- Private Methods --------------------
    
#endregion
}}
