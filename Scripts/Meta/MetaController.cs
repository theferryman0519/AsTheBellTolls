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

namespace AsTheBellTolls.Meta {
public class MetaController : Singleton<MetaController> {

#region -------------------- Serialized Variables --------------------
    [Header("Sub Controllers")]
    [SerializeField] private CookingSubController _cookingSubController;
    [SerializeField] private FishingSubController _fishingSubController;
    [SerializeField] private ForagingSubController _foragingSubController;
    [SerializeField] private InventionsSubController _inventionsSubController;
    [SerializeField] private MemoriesSubController _memoriesSubController;
    [SerializeField] private RelationshipsSubController _relationshipsSubController;
    [SerializeField] private RestorationSubController _restorationSubController;
    [SerializeField] private TonicsSubController _tonicsSubController;
#endregion
#region -------------------- Public Variables --------------------
    public CookingSubController Cooking => _cookingSubController;
    public FishingSubController Fishing => _fishingSubController;
    public ForagingSubController Foraging => _foragingSubController;
    public InventionsSubController Inventions => _inventionsSubController;
    public MemoriesSubController Memories => _memoriesSubController;
    public RelationshipsSubController Relationships => _relationshipsSubController;
    public RestorationSubController Restoration => _restorationSubController;
    public TonicsSubController Tonics => _tonicsSubController;
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
