# HW2
## Devlog
The inital plan that I drew up for this poject outlined diffrent game classes and objects 

3 classes - UI, Coins, and Player
- the player Class handles movement collision and coin collection for the player. 
- the coing class handles movement for the coin as the player will be stationary aside from being able to jump
- and finally the UI class handles the UI updating for the game

I also diagramed what methods I would need for this game

- A method for coin collection 
- and a method for jumping

After doing this drawing and planning out my game I started by creating a prefab for the player as well as the coin. The diagraming was able to guide me towards creating the correct classes right away and compartmentalize the diffrent scripts I would need to create - I ended up creating a total of 3 scripts, Player Script, Coin Sript, and a Spawn Script - somthing initally missing from my diagram but I realized I needed after starting the project and started working. 

After I started writing these  scripts I created diffrent methods to handle the actions taken in the game, one of which that I had diagramed and then created the method _CollectCoin which adds +1 to the score, and updates the UI

The coin deletion is handled by the coin script through a method written inside that class which deletes the coin when the trigger on the coin is activated. 

Finally I ended up not creating a class for the UI opting rather to handle the UI from the player class itself, finding this to currently be a simpler option since the UI only needs one piece of text which can easily be handled by a few lines of code.





## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
