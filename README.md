-------------------------------
Design Document - Michael Nardi
-------------------------------
Walking Simulator
-------------------------------
Crossplatform Development
-------------------------------

0.0 Brief Game Overview

	0.1 Considerations

		All assets are freely aquired and used from the Unity Asset Store and all credit for the original creators of them are mentioned in the asset list section

	0.2 Links

		GitHub repository link: https://github.com/Kiandisor/Walking-Simulator-Assessment

	0.3 Game Concept

		- The player will walk around collecting items and can collect them with left click or by tapping on it.
		- Items will spawn randomly and in different positions.
		- The player will collect items which have puzzles to get to them
		- The objective of this game will be to explore different areas of the map.

	0.4 Game Cornerstones

		- Cornerstone 1: Freedom of movement
		- Cornerstone 2: Puzzles
		- Cornerstone 3: TBD 

	0.5 Gameplay

	0.6 Controls
		0.5.1 PC
			- PC would use W/S/A/D and the right mouse button to control the player.
			- Left click will be used to interact with objects
		0.5.2 Android
			- On the phone the player will be able to move around with the left joystick and rotate the head with the right joystick.
			- Tapping the object while looking at it will allow the player to interact with the object 

0.2 Game Requirements

	0.2.1 API/Software Requirements

	0.2.2 Tools, API and methods use for crossplatform issues

1.0 Game Mechanics

	1.1 Player 

		1.1.1 Player movement
			- The player will be able to move like in any other game by moving forward, back, left, right and jumping 
			- The player will be aided by a compass at the top left of the screen but will not have any maps 
			- As the only item the player will be collecting is crystals there will be no bags but will instead just increase a counter for how many they have. This will decrease when one is placed down 
			- The movement will be kept simple to allow for more time to work on puzzles and scenery 
			- The player will be able to interact with items and certain objects like light switches and rocks and any items involved with a puzzle

	1.2 Items
		
		- The main item of the game are the crystals which the player will be collecting from around the world to take back to the final puzzle
		- Any additional items related to puzzles will be added here
		- Currently no other items are planned

	1.3 Puzzles

		- Place crystals found around the world in a triangle to unlock a hidden cave 
		- Each crystal will be acquired from a unique puzzle that the player will search for in the world 
		- There will be hopefully an infinite amount of crystals which will constantly be spawning randomly (all subject to change) 
		- Some locations for them include: hills, houses, other caves, under trees, hidden under other objects, only visible with light/no light 
		- Maybe a riddle for each of the locations where and how the crystal will be found and the puzzle associated with it or little clues around the world 
		- Player will be able to get crystals in any order but will need to place them all at the same time since getting to the spot will involve a puzzle in itself and will reset when they leave the place

			1.3.1 Puzzle Concepts
				- Puzzles will be fantasy game inspired especially from wow experiences and other games I have played 
				- A crystal can be found by doing a hill climb to the top once there's the player can have a birds eye view of the map which will work as a map of sorts 
				- once there the player is able to choose between a "roll of faith" or just walk down the road they came up again. There will be a lake of water at the bottom of the hill to catch the player 
				- Another crystal will be found in a old elf house where it was hidden away by the end and requires light to be shined on it to be visible 
				- After that there will be a cave which the player will need to make their way through a maze which will have minimal lighting 
				- There will be crystals around the world randomly and even in plain sight so the player will need to keep an eye out for them and take their time 
				- Once the player has gotten all of the crystals they will make their way over to the place in the woods where the sun creates a ring of light
				- To get to the place they will need to have found clues from the previous places they have been our go back up the hill and search for it by looking 
				- Time will be the biggest issue with the puzzles and making sure it's not being over done 

	1.4 Environment

		- The environment of the game will be based on a fanatasy forest which will hold different levels of terrain to make it less static and make exploring worth while
		- Each puzzle will be made indervidualy to avoid creating too many priorities and making the puzzles easier to make
		- Once completed the puzzles will be joined to eachother by the use of trees, bushes, paths, hills and caves which will fill in the empty surrounding areas around the puzzles

2.0 Assets List

	2.1 Environment
		Bushes:
			https://assetstore.unity.com/packages/3d/vegetation/plants/yughues-free-bushes-13168
		Trees & Land:
			https://assetstore.unity.com/packages/3d/environments/nature-starter-kit-2-52977
			https://assetstore.unity.com/packages/3d/environments/fantasy/fantasy-forest-environment-free-demo-35361
	2.2 Items

		- TBD (Crystal Model)	

	2.3 Buildings
		https://assetstore.unity.com/packages/3d/environments/fantasy/free-fantasy-medieval-houses-and-props-pack-167010
		https://assetstore.unity.com/packages/3d/environments/fantasy/medieval-fantasy-house-31856
3.0 GUI Mockups

	3.1 Menu Mockups
		Below are the menu on each platform, it will simply have a start and quit button but will change depending on the platforms limits:

		3.1.1 PC

		3.1.2 Android

	3.2 HUD Mockups

		3.2.1 PC

		3.2.2 Android

	3.3 Screen size and aspect ratio difference

4.0 Timeline/Schedule

	Week 1:
		- Pre-production documentation
		- Finding assets to use
		- Basic Game Mechanics
	Week 2:
		- Elaborate on Puzzles and concepts
		- Description on environment
		- HUD Concepts
	Week 3:
		- Player movement and basic interaction
		- Puzzle One (Hill)
	Week 4:
		- Interactions
		- Puzzle Two (Cave)
	Week 5:
		- HUD
		- Puzzle Three (Elf House)
	Week 6:
		- HUD/Menus (Pause and Main)
		- Puzzle Four (**End Puzzle)
	Week 7:
		- Puzzle Five or Puzzle Clues
	Week 8:
		- Android Controls
		- Extras

	* TBD based off if there are more puzzles
