# Justice Bird

  Project for COP4331-Fall 2017
  
  | Group Members |
  |:-------------:|
  | @3alanhdez - Alan Hernandez |
  | @kingofspill - Grant Goodman |
  | @marcburrell - Marc Burrell |
  | @mohammadh94 - Mohammad Hammad |
  | @sustx - William Tyback Rojas |
  
  ### Demo Video
    https://www.youtube.com/watch?v=gQmSUSPGisU (Link formatting will not work)

## Vision Statement

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;We are living in a time of history where it seems like every time you hear about the news, you get ready for something disappointing, enraging, frightening, and sometimes all three. So for those who need a break from the chaos we now call news we have released Justice Pigeon, a game which allows you to fly across various terrains as a bird while also avoiding obstacles and gaining points along the way. The best part of our game however is the ability to defecate on the heads of those who you are tired of seeing on the news every single week. On the contrary of what you may be thinking, our birds are bipartisan so everybody has an equal oppurtunity to get pooped on, no matter their political views. Our game is a fun way to unwind and can even provide a method of relief from the daily news. This supports our company’s strategy to release games which are not only exciting but also relevant to the current times.  

## Product Backlog

  ### User Stories
 
  | UID | User Story |
  |---:|:-----------|
  | 00 | “As a player, I want to be able to start the game, so I can play.” |
  | 01 | “As a player, I want to be able to pause the game, so that I can take breaks from it.” |
  | 02 | "As a player, I want the world to change each time I play, so that the game stays fun over time" |
  | 03 | “As a player, I want a way to track my progress, so I can visualize my accomplishment." |
  | 04 | “As a player, I want a way to view the interesting objects in my nest, so I can visualize my collection.”|
  | 05 | “As a player, I want to be able to adjust graphics settings, so I can ensure good performance on my device.” |
  | 06 | “As a player, I want a way to score my ability, so that I can compare myself with other players.” |
  | 07 | “As a player, I want to be able to save my progress on exiting the game, so that I can return later.” |
  | 08 | "As a player, I want to be able to exit the game, so that I can do other things." |
  | 09 | "As a player, I want to be able to control the bird, so I can explore and interact with the game world." |
  | 10 | "As a player, I want to collect coins, so that I can buy things." |
  | 11 | "As a bird,   I want to be able to eat food, so that I can poop on things." |
  | 12 | "As a player, I want to be able to change how my poop looks, so I can feel ownership over my game." |
  | 13 | "As a bird,   I want to be able to poop on things, so that I can eat more food." |
  | 14 | "As a player, I want to be able to customize my bird, so I can feel ownership over my game" | 
  | 15 | "As a player, I want a central location that displays my choices, so I can choose what to do." |
  | 16 | "As a player, I want to hear music while I play, so I don't get bored." |
  
  ### Functional Requirements

  | RID | UID | Feature | Assigned To | Points |
  |---:|--------------:|:--------|:------:|:-----:|
  | 00 | 01 | The game shall allow the player to pause the game                | @kingofspill |1|
  | 01 | 01 | The game shall allow the player to un-pause the game             | @kingofspill |1|
  | 02 | 09 | The game shall allow the player to control the bird’s flight     | @kingofspill |2|
  | 03 | 09 | The game shall allow the player to make the bird poop            | @mohammadh94 |3|
  | 04 | 02 | The game shall generate a cityscape modularly                    | @kingofspill |8|
  | 05 | 02 | The game shall have a set of modular city tiles                  | @3alanhdez, @kingofspill   |8|
  | 06 | 04 | The game shall allow the player to view total collected coins    | @marcburrell |3|
  | 07 | 06 | The game shall display a score, dependant on the player's actions| @marcburrell |2|
  | 08 | 08 | The game shall allow the player to exit the application          | @kingofspill   |1|
  | 09 | 02 | The game shall generate non playable characters pseudo-randomly  | @kingofspill |8|
  | 10 | 10 | The game shall allow the player to collect collectable items     | @suxstx   |5|
  | 11 | 11 | The game shall generate food pseudo-randomly                     | @sustx |8|
  | 12 | 05 | The game shall provide a method for changing common graphical settings | @mohammadh94 |1|
  | 13 | 03 | The game shall allow the player to see the available poop | @mohammadh94 |5|
  | 14 | 07 | The game shall store persistent player progress                  | @kingofspill   |8|
  | 15 | 07 | The game shall allow the player to load previously stored progress | @kingofspill   |5|
  | 16 | 12 | The game shall allow the player to change the bird's poop cosmetically | @mohammadh94   |5|
  | 17 | 03 | The game shall track the total number of coins the player has collected | @sustx |1|
  | 18 | 14 | The game shall allow players to spend in-game currency on alternative skins for the bird and poop | @kingofspill |13|
  | 19 | 09 | The game shall end play when the bird collides with environment objects | @marcburrell   |3|
  | 20 | 08 | The pause screen shall give a way to exit the game | @kingofspill | 3 |
  | 21 | 01 | The pause screen shall allow the player to quit to a main menu | @kingofspill | 3 |
  | 22 | 15 | The game shall have a main menu | @kingofspill | 3 |
  | 23 | 00 | The main menu shall allow the player to start the game | @kingofspill | 1 |
  | 24 | 08 | The main menu shall allow the player to quit the game | @kingofspill | 3 |
  | 25 | 14 | The main menu shall allow the player to go to a customization page | @marcburrell | 3 |
  | 26 | 13 | The game shall add poop as the bird collects food | @marcburrell | 3 |
  | 27 | 10 | The game shall spawn coins when poop hits non-playable characters | @3alanhdez | 5 |
  | 28 | 06 | The game shall increase score as the player survives longer | @marcburrell | 2 |
  | 29 | 13 | The game shall have a set of non-playable characters to spawn | @3alanhdez, @kingofspill | 5 |
  | 30 | 11 | The game shall have food models to spawn | @sustx | 3 |
  | 31 | 14 | The customization page shall have list of skin options for the bird | @marcburrell | 3 |
  | 32 | 12 | The customization page shall have list of skin options for the poop | @marcburrell | 3 |
  | 33 | 15 | The game shall have a customization page | @marcburrell | 1 |
  | 34 | 02 | The game shall have a set of obstacles to spawn | @kingofspill | 8 |
  | 35 | 02 | The game shall spawn obstacles pseudo-randomly | @kingofspill | 3 |
  | 36 | 15 | The customization page shall allow the player to spend coins on locked customization options | @marcburrell | 5 |
  | 37 | 16 | The game shall play music during gameplay | @sustx | 5 |
  | 38 | 17 | The game shall have a set of buildings to make up the city tiles | @3alanhdez, @kingofspill | 5 |

  ### Functional Test
  | RID Being Tested | Method Of Testing |
  |:----------------:|:------------------|
  | 00 | [Assets/Tests/R00Test.txt](Assets/Tests/R00Test.txt) |
  | 01 | [Assets/Tests/R01Test.txt](Assets/Tests/R01Test.txt) |
  | 02 | [Assets/Tests/R02Test.txt](Assets/Tests/R02Test.txt) |
  | 03 | [Assets/Tests/R03Test.txt](Assets/Tests/R03Test.txt) |
  | 04 | [Assets/Tests/R04Test.txt](Assets/Tests/R04Test.txt) |
  | 05 | etc... |

  ### Unit Tests
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
  
  

  ### Sprint 1
  
  | Feature RID | Status | Assigned To | Points |
  |:----:|:------:|:------:|:----:|
  | 02  | Complete | @kingofspill | 2 |
  | 04  | Complete | @3alanhdez   | 5 |
  | 05  | Complete | @3alanhdez   | 5 |
  | 06  | Complete | @marcburrell | 2 |
  | 07  | Complete | @marcburrell | 2 |
  
  ### Sprint 1 Burndown Chart
 
 [Sprint 1](https://raw.githubusercontent.com/KingOfSpill/justice-bird/master/Documentation/burndown1.png)
  
  ### Sprint 2 
  
  | Feature RID | Status | Assigned To | Points |
  |:----:|:------:|:------:|:----:|
  | 00  | Complete  | @kingofspill | 1  |
  | 01  | Complete  | @kingofspill | 1  |
  | 03  | Complete  | @mohammadh | 3  |
  | 04  | Complete  | @kingofspill | 8  |
  | 05  | Complete  | @3alanhdez | 8  |
  | 06  | Complete  | @marcburrell | 3  |
  | 07  | Complete  | @marcburrell | 2  |
  | 09  | Complete  | @kingofspill | 8  |
  | 11  | Complete  | @sustx | 8  |
  | 13  | Complete  | @mohammadh | 5  |
  | 17  | Complete  | @sustx | 1  |
  | 19  | Complete  | @marcburrell | 3  |
  | 22  | Complete  | @kingofspill | 3  |
  | 23  | Complete  | @kingofspill | 1  |
  | 24  | Complete  | @kingofspill | 3  |
  | 26  | Complete  | @marcburrell | 3  |
  | 27  | Complete  | @3alanhndez | 5  |
  | 28  | Complete  | @marcburrell | 2  |
  | 29  | Complete  | @3alanhndez | 5  |
  | 30  | Complete  | @sustx | 3  |
  
  
  
  ### Sprint 2 Burndown Chart
 
 [Burndown Chart](https://raw.githubusercontent.com/KingOfSpill/justice-bird/master/Documentation/sprintBurndown.png)
 
 
  
  ### Sprint 3 Backlog
   
  | Feature RID | Status | Assigned To | Points |
  |:----:|:------:|:------:|:----:|
  | 05  | Complete 07/18 | @3alanhdez, @kingofspill | 8 |
  | 08  | Complete 07/16 | @kingofspill | 1 |
  | 10  | Complete 07/20 | @sustx | 5 |
  | 12  | Complete 07/20 | @mohammadh | 1 |
  | 14  | Complete 07/15 | @kingofspill | 8 |
  | 15  | Complete 07/15 | @kingofspill | 5 |
  | 16  | Complete 07/19 | @mohammadh | 5 |
  | 18  | Complete 07/20 | @kingofspill | 13 |
  | 20  | Complete 07/16 | @kingofspill | 3 |
  | 21  | Complete 07/16 | @kingofspill | 3 |
  | 25  | Complete 07/18 | @marcburrell | 3 |
  | 29  | Complete 07/20 | @3alanhdez, @kingofspill | 5 |
  | 30  | Complete 07/19 | @sustx     | 3 |
  | 31  | Complete 07/18 | @marcburrell | 3 |
  | 32  | Complete 07/20 | @marcburrell | 3 |
  | 33  | Complete 07/18 | @marcburrell | 1 |
  | 34  | Complete 07/18 | @3alanhdez, @kingofspill | 8 |
  | 35  | Complete 07/14 | @kingofspill | 3 |
  | 36  | Complete 07/20 | @marcburrell | 5 |
  | 37  | Complete 07/19 | @sustx | 5 |
  | 38  | Complete 07/18 | @3alanhdez, @kingofspill | 5 |
  
  
  

## Design Specification

[Class Diagram](https://raw.githubusercontent.com/KingOfSpill/justice-bird/master/Documentation/DesignDoc.png)
[Use-Case Diagram](https://raw.githubusercontent.com/KingOfSpill/justice-bird/master/Documentation/UseCaseDiagram.png)
