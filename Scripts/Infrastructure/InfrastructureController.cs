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
    
#endregion
#region -------------------- Initial Functions --------------------
    
#endregion
#region -------------------- Coroutines --------------------
    
#endregion
#region -------------------- Public Methods --------------------
    
#endregion
#region -------------------- Private Methods --------------------
    
#endregion
}}
