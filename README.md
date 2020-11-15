# Asteroids

Implementation for Atari's Asteroids game.

Note: This implemtation has platform independent compiled code . To use keyboard input set the build target as Standalone. To use Touch input set the build target to Android.

# Game Elements

## Player

score: inceases when player hit an asteroid. score value for asteroid hit can be set from (_BigAsteroidScore, _MediumAsteroidScore, _SmallAsteroidScore) in Assets\ScriptableObjects\Variables

lives: Number of tries player can play the game. lives reduces when spaceship is hit by an asteroid. Max number of lives can be set from Assets\ScriptableObjects\Variables\MaximumLives

## Spaceship

movement speed: Force value that applied to move the spaceship. That can be set on the spaceship object inside the Movement component. force mode for movement can be set too.

rotatation speed: Rotation angle that the ship can rotate per second. That can be set on the spaceship object inside the Movement component.

## Asteroid Spawner

can be used to spawn object to its position. Asteroid start velocity can be set in Asteroid Spawner component.

## Asteroid Spawners

Controls spawners that are children to its object. spawns an asteroid in a random spawner with a spawn rate that can be changed in Over Time Spawner component.
