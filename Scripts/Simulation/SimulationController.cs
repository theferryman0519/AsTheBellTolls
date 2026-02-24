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

namespace AsTheBellTolls.Simulation {
public class SimulationController : Singleton<SimulationController> {

#region -------------------- Serialized Variables --------------------
    [Header("Sub Controllers")]
    [SerializeField] private AnimalsSubController _animalsSubController;
    [SerializeField] private CharactersSubController _charactersSubController;
    [SerializeField] private CropsSubController _cropsSubController;
    [SerializeField] private SchedulesSubController _schedulesSubController;
    [SerializeField] private WeatherSubController _weatherSubController;
    [SerializeField] private WorldSubController _worldSubController;
#endregion
#region -------------------- Public Variables --------------------
    public AnimalsSubController Animals => _animalsSubController;
    public CharactersSubController Characters => _charactersSubController;
    public CropsSubController Crops => _cropsSubController;
    public SchedulesSubController Schedules => _schedulesSubController;
    public WeatherSubController Weather => _weatherSubController;
    public WorldSubController World => _worldSubController;
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
