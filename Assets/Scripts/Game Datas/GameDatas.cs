﻿
using System.Collections.Generic;
using System.Linq;

public class GameDatas
{
    private static GameDatas _instance;
    public static GameDatas Instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameDatas();
            return _instance;
        }
    }

    private List<PlacableItemArchetype> _placableItemArchetypes = new List<PlacableItemArchetype>()
    {
        new PlacableItemArchetype()
        {
            ItemType = PlacableItemType.ROCK,
            SpritePath = "Sprites/Items_Muraille1_MenuSprite",
            PrefabPath = "Prefabs/PlacableItems/BackwardRectangle",
            Cost = 5
        },
        new PlacableItemArchetype()
        {
            ItemType = PlacableItemType.TREE,
            SpritePath = "Sprites/Items_Muraille3_MenuSprite",
            PrefabPath = "Prefabs/PlacableItems/ForwardRectangle",
            Cost = 5
        },
        new PlacableItemArchetype()
        {
            ItemType = PlacableItemType.BUMPER,
            SpritePath = "Sprites/Item_bumper",
            PrefabPath = "Prefabs/PlacableItems/Bumper",
            Cost = 10
        },
        new PlacableItemArchetype()
        {
            ItemType = PlacableItemType.FLIPPER,
            SpritePath = "Sprites/Items_Flipper1",
            PrefabPath = "Prefabs/PlacableItems/Flipper",
            Cost = 20
        },
        new PlacableItemArchetype()
        {
            ItemType = PlacableItemType.BOXEG,
            SpritePath = "Sprites/Items_Boxe2",
            PrefabPath = "Prefabs/PlacableItems/BoxeG",
            Cost = 30
        },
        new PlacableItemArchetype()
        {
            ItemType = PlacableItemType.BOXED,
            SpritePath = "Sprites/Items_BoxeD2",
            PrefabPath = "Prefabs/PlacableItems/BoxeD",
            Cost = 30
        },
        new PlacableItemArchetype()
        {
            ItemType = PlacableItemType.PORTAL,
            SpritePath = "Sprites/Items_Portal1",
            PrefabPath = "Prefabs/PlacableItems/Portal",
            Cost = 70
        }
    };

    private GameDatas()
    { }

    public List<PlacableItemArchetype> GetPlacableItemArchetypes()
    {
        return _placableItemArchetypes;
    }

    public PlacableItemArchetype GetPlacableItemArchetypeByType(PlacableItemType itemType)
    {
        return _placableItemArchetypes.First(archetype => archetype.ItemType == itemType);
    }
}