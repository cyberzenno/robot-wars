# Robot Wars

Another interview test that I've seen many times around. It happened also to me and with this solution they got me in for the face to face.
The purpose of the exercise was to show off some skills such as Design Patterns, Unit Tests and Mocking and some common sense. It took me somewhere around 6 hours to do it.
Unfortunately I didn't find the original requirements, but I sketched up the basics.

There is an Arena 5x5 and a Robot. The the robot can execute L, R and M command and it has an orientation (N, W, S, E).
If the robot attempt to get out the arena, it gets a Penality but doesn't move.

Based on this we expect to satisfy the following scenarios:

### Scenario 1
Initial position: 0, 2, E  
Send commands: MLMRMMMRMMRR   
Final position: 4, 1, N  
Penalties: 0

## Scenario 2
Initial position: 4, 4, S  
Send commands: LMLLMMLMMMRMM  
Final position: 0, 1, W  
Penalties: 1

## Scenario 3
Initial position: 2, 2, W   
Send commands: MLMLMLMRMRMRMRM   
Final position: 2, 2, N  
Penalties: 0  

## Scenario 4 
Initial position: 1, 3, N  
Send commands: MMLMMLMMMMM   
Final position: 0, 0, S  
Penalties: 3

### [Similar Repos](https://github.com/search?utf8=%E2%9C%93&q=robotwars&type=)
