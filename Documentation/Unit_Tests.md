  | TID | Test Description | RID Being Tested | Method Of Testing |
  |:---:|:-----------------|:----------------:|:------------------|
  | 00  | The pause button pauses the game                                          | 00 | [PauseControllerTests.cs](Assets/Tests/Editor/PauseControllerTests.cs) |
  | 01  | The unpause button unpauses the game                                      | 01 | [PauseControllerTests.cs](Assets/Tests/Editor/PauseControllerTests.cs) |
  | 02  | The bird moves up when you press 'up' button                              | 02 | [BirdControllerTests.cs](Assets/Tests/Editor/BirdControllerTests.cs) |
  | 03  | The bird moves down when you press 'down' button                          | 02 | [BirdControllerTests.cs](Assets/Tests/Editor/BirdControllerTests.cs) |
  | 04  | The bird moves left when you press 'left' button                          | 02 | [BirdControllerTests.cs](Assets/Tests/Editor/BirdControllerTests.cs) |
  | 05  | The bird moves right when you press 'right' button                        | 02 | [BirdControllerTests.cs](Assets/Tests/Editor/BirdControllerTests.cs) |
  | 06  | The bird doesn't move past the left edge                                  | 02 | [BirdControllerTests.cs](Assets/Tests/Editor/BirdControllerTests.cs) |
  | 07  | The bird doesn't move past the right edge                                 | 02 | [BirdControllerTests.cs](Assets/Tests/Editor/BirdControllerTests.cs) |
  | 08  | The bird doesn't move past the up edge                                    | 02 | [BirdControllerTests.cs](Assets/Tests/Editor/BirdControllerTests.cs) |
  | 09  | The bird doesn't move past the down edge                                  | 02 | [BirdControllerTests.cs](Assets/Tests/Editor/BirdControllerTests.cs) |
  | 10  | The Poop Spawner can spawn poop                                           | 03 | [PoopSpawnerTests.cs](Assets/Tests/Editor/PoopSpawnerTests.cs) |
  | 11  | The Poop Spawner does not spawn poop if the poop bar is empty             | 03 | [PoopSpawnerTests.cs](Assets/Tests/Editor/PoopSpawnerTests.cs) |
  | 12  | The Module Spawner calculates continuous weights properly                 | 04 | [ModuleSpawnerTests.cs](Assets/Tests/Editor/ModuleSpawnerTests.cs) |
  | 13  | The Module Spawner calculates total weight properly                       | 04 | [ModuleSpawnerTests.cs](Assets/Tests/Editor/ModuleSpawnerTests.cs) |
  | 14  | The Module Spawner can spawn a module                                     | 04 | [ModuleSpawnerTests.cs](Assets/Tests/Editor/ModuleSpawnerTests.cs) |
  | 15  | There are a set of prefabs for the module spawner to spawn                | 05 | Check if there are files in [Assets/Resources/Tiles](Assets/Resources/Tiles) |
  | 16  | The function getCoin increments the on-screen coin counter                | 06 | [UIScriptTests.cs](Assets/Tests/Editor/UIScriptTests.cs) | 
  | 17  | The function changeScore changes the on-screen score counter              | 07 | [UIScriptTests.cs](Assets/Tests/Editor/UIScriptTests.cs) | 
  | 18  | The Obstacle Spawner can spawn Obstacles                                  | 09 | [ObstacleSpawnerTests.cs](Assets/Tests/Editor/ObstacleSpawnerTests.cs) | 
  | 19  | The Food Spawner can spawn food                                           | 11 | [FoodSpawnerTests.cs](Assets/Tests/Editor/FoodSpawnerTests.cs) |
  | 20  | Collect poop in the game and the poop bar grows                           | 13 | Performed Manually |
  | 21  | Collect poop in the game and the poop bar shrinks                         | 13 | Performed Manually |
  | 22	| Collect a coin in the game and the coin counter increments                | 17 | Performed Manually |
  | 23  | Run into an NPC in the game and the death screen appears                  | 19 | Performed Manually |
  | 24  | There is a scene in the game with the title of the game                   | 22 | Performed Manually |
  | 25  | In the main menu scene, press the start button and the game scene loads   | 23 | Performed Manually |
  | 26  | In the main menu scene, press the quit button and the application closes  | 24 | Performed Manually |
  | 27  | Collect poop in the game and the poop bar grows                           | 26 | Performed Manually |
  | 28  | Play the game and over time the score counter increases                   | 28 | Performed Manually
  | 29  | There are a set of prefabs for the NPC spawner to spawn                   | 29 | Check if there are files in [Assets/Resources/NPCs](Assets/Resources/NPCs) |
  | 30  | There is a file Food.prefab                                               | 30 |  Check if there are files in [Assets/Prefabs](Assets/Prefabs) |
