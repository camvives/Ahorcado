Feature: Juego_Ahorcado
		In order to play ahorcado
	As a user of the website
	I want to know if I won or lost

@partida
Scenario: Player wins the game letter by letter
	Given The word to guess 'AGILES'
	When Player entered A as the LetraIntresada
	And Player entered G as the LetraIntresada
	And Player entered I as the LetraIntresada
	And Player entered L as the LetraIntresada
	And Player entered E as the LetraIntresada
	And Player entered S as the LetraIntresada
	Then Player should be told that he lost the game

