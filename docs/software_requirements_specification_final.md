# Overview

<Describe the purpose of this document in 1 paragraph of less … hint: it is
your SRS>

# Software Requirements

<Describe the structure of this section>
  
## Functional Requirements
  
### Inventory Screen
| ID | Requirement |
| :-------------: | :----------: |
| FR1 | Inventory should open as an overlay on the level screen. |
| FR2 | Inventory should open when an icon on screen is pressed. |
| FR3 | Inventory should display all collected items. |
| FR4 | Movement controls should not be accessible while the inventory screen is open. |
| FR5 | Inventory should close when the icon is clicked while it is open. |

### Player Sprite
| ID | Requirement |
| :-------------: | :----------: |
| FR6 | The player sprite should move in the four cardinal directions. |
| FR7 | Player sprite should move when arrows on the screen are pressed. |
| FR8 | Player sprite should stop when arrows on the screen are released. |
| FR9 | Player sprite should change the direction it appears to face based off direction of movement. |
| FR10 | Player sprite should animate while moving, but not while stationary. |

### Levels
| ID | Requirement |
| :-------------: | :----------: |
| FR11 | Player sprite should animate while moving, but not while stationary. |
| FR12 | Player should be able to move back and forth between levels. |
| FR13 | Some levels should be inaccessible unless a certain item is in the inventory. |
| FR14 | Player character should be loaded into different parts of the level based on which other level he entered from. |
| FR15 | Inventory should be loaded from persistent object on every level change. |

### Item Collection
| ID | Requirement |
| :-------------: | :----------: |
| FR16 | Key items should be collected upon contact with the player character. |
| FR17 | Which key items have been collected should be stored in the inventory. |
| FR18 | Key item collection shall be necessary to progress to new areas of the game. |
| FR19 | Player should be required to collect all ship repair items to complete the game. |
| FR20 | Key item sprites should disappear from the level map after they are collected. |

### Collision
| ID | Requirement |
| :-------------: | :----------: |
| FR21 | Levels should be surrounded by collision to ensure player does not leave the intended screen area. |
| FR22 | All levels should contain other collidable objects as obstacles. |
| FR23 | All non-ground and non-floor tiles should be collidable. |
| FR24 | Player character should also collide with water. |
| FR25 | Player sprite movement speed should decrease when walking over certain areas of the map. |


## Non-Functional Requirements
### Opening Animation
| ID | Requirement |
| :-------------: | :----------: |
| NFR1 | Game should play opening animation after game is started on the title screen. |
| NFR2 | Opening animation should lead into game after the user has tapped the screen. |
| NFR3 | Opening animation should show the alien crashing onto the planet. |
| NFR4 | Title Screen should contain the name of the game. |
| NFR5 | Aspect ratio should be 4:3, framerate should be 5 FPS. |
| NFR6 | Animation should last approximately 6 seconds. |

### Ending Animation
| ID | Requirement |
| :-------------: | :----------: |
| NFR7 | Ending animation should show the alien leaving the planet. |
| NFR8 | Game should return to the title screen after the ending animation plays. |
| NFR9 | Art style should match between closing animation, opening animation, and the rest of the game. |
| NFR10 | Aspect ratio should be 4:3, framerate should be 5 FPS. |
| NFR11 | Animation should last approximately six seconds. |
| NFR12 | Animation should only play if the game has been completed. |

### Controls
| ID | Requirement |
| :-------------: | :----------: |
| NFR13 | All game controls should be touchscreen-based. |
| NFR14 | Movement arrows should be on the right side of the screen. |
| NFR15 | Inventory icon should be on the bottom left side of the screen. |
| NFR16 | Visible area of the level map should take up the entire screen (no black bars under the controls). |
| NFR17 | Player speed should be quick enough to move around the map in a reasonable amount of time, but not so fast as to be difficult to control. |

### Art Design
| ID | Requirement |
| :-------------: | :----------: |
| NFR18 | Tileset should be in blocks 64x64 pixels wide. |
| NFR19 | Tiles should be colorful. |
| NFR20 | Tiles for ground, water, indoor floor, and walls should be available for use. |
| NFR21 | Environmental obstacles such as trees, rocks, and furniture should be created. |
| NFR22 | Player character should be 1 tile tall (64 pixels). |

### Compatibility
| ID | Requirement |
| :-------------: | :----------: |
| NFR23 | The game should be developed using Unity. |
| NFR24 | Version 2020.3.19f1 should be used, regardless of any updates to unity during the duration of the project. |
| NFR25 | Testing during development should be done using Unity Remote 5 on android devices. |
| NFR26 | The game should be played in landscape mode. |
| NFR27 | Final APK should be compatible with kitkat version of Android and above. |

  
  # Change management plan
  
Thank you for considering STAR CRASH as an entertainment option at your medical practice.  In interest of making your transition from the old system to the new as seamless as possible for you and your patients, this document contains a plan for how to switch.

### 1:  Integrating the game
  This game is Android based and will run on android devices running version 4.4 and higher.  This includes both phones and tablets.  A     Wi-Fi connection will be needed to download the game, but once it is downloaded, Wi-Fi will no longer be needed.
  The tablets or phones used to play the game will need to be charged.  For this, we suggest using wireless charging in the place the       phones and/or tablets are stored in your waiting room, as this is easier for a child to do than to plug a device in to charge.  However,   wired chargers also work.
  When switching to using STAR CRASH as waiting room entertainment at your medical practice, it is entirely your choice whether you wish     to switch from the old toys and games overnight or make the transition more slowly, over the course of several days or weeks.
### 2:  Training on Use
  We understand that as most of our clients are pediatricians’ offices or pediatric dentists that many of the users of our game are young   children who may not have a good understanding of how to play mobile games or top-down adventures.  For this reason, when you purchase     our software, we will also send you posters explaining to children how the game works.  These include:
  + Using hand sanitizer before and after using the touchscreens
  + Controlling the game by using the arrows on screen to move the player
  + Winning the game by collecting all items to repair the ship
  + Putting the phone/tablet away when they are done

### 3:  Resolving issues
  Should you find a problem with the game such as a glitch, please email us at issue@starcrash.com.  We will work to resolve that issue     and you will then be able to download an uploaded and fixed version of the game to your devices.

  
# Traceability links
  
<Description of this section>
  
## Use Case Diagram Traceability
| Artifact ID | Artifact Name | Requirement ID |
| :-------------: | :----------: | :----------: |
|[UseCase_ShipRepair.jpg](https://github.com/Lauren-Vanderklok/GVSU-CIS641-Android-Game/blob/master/artifacts/functional-models/UseCase_ShipRepair.jpg)|ShipRepair|FR19|
  |[Level Unlock Use Case.jpg](https://github.com/Lauren-Vanderklok/GVSU-CIS641-Android-Game/blob/master/artifacts/functional-models/Level%20Unlock%20Use%20Case.jpg)|Level Unlock|FR18|
  |[Diagrams Collision-Usecase.drawio.png](https://github.com/Lauren-Vanderklok/GVSU-CIS641-Android-Game/blob/master/artifacts/functional-models/Diagrams%20Collision-Usecase.drawio.png)|Collision|FR25|
  |[Collect_Item_use_case_diagram.drawio.png](https://github.com/Lauren-Vanderklok/GVSU-CIS641-Android-Game/blob/master/artifacts/functional-models/Collect_Item_use_case_diagram.drawio.png)| Collect Item |FR17|

  
## Class Diagram Traceability
| Artifact Name | Requirement ID |
| :-------------: |:----------: |
  |[Class diagram.png](https://raw.githubusercontent.com/Lauren-Vanderklok/GVSU-CIS641-Android-Game/master/artifacts/Class%20diagram.png)|FR3, FR6, FR7, FR8, FR13, FR17, FR25|

  
## Activity Diagram Traceability
<In this case, it makes more sense (I think, feel free to disagree) to link
to the file and to those requirements impacted>
| Artifact ID | Artifact Name | Requirement ID |
| :-------------: | :----------: | :----------: |
| <filename> | Handle Player Input | FR1-5, NFR2 |
  |[ActivityDiagram_ShipRepair.jpg](https://github.com/Lauren-Vanderklok/GVSU-CIS641-Android-Game/blob/master/artifacts/functional-models/ActivityDiagram_ShipRepair.jpg)|Ship Repair|FR19|
  |[Collect_Item_Activity_Diagram.drawio.png](https://github.com/Lauren-Vanderklok/GVSU-CIS641-Android-Game/blob/master/artifacts/functional-models/Collect_Item_Activity_Diagram.drawio.png)|Collect Item|FR16, FR17, FR20|
  |[Diagrams Collision-Activity Diagram.drawio.png](https://github.com/Lauren-Vanderklok/GVSU-CIS641-Android-Game/blob/master/artifacts/functional-models/Diagrams%20Collision-Activity%20Diagram.drawio.png)|Collision|FR25|

  
# Software Artifacts
<Describe the purpose of this section>
* [I am a link](to_some_file.pdf)
