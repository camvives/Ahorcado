Feature: Juego_Ahorcado
		In order to play ahorcado
	As a user of the website
	I want to know if I won or lost

@partida
Scenario: Player wins the game letter by letter
	Given The word to guess 'AGILES'
	When Player entered A as the LetraIngresada
	And Player entered G as the LetraIngresada
	And Player entered I as the LetraIngresada
	And Player entered L as the LetraIngresada
	And Player entered E as the LetraIngresada
	And Player entered S as the LetraIngresada
	Then Player should be told that he won the game

@partida
Scenario: Player loses the game letter by letter
	Given The word to guess 'AGILES'
	When Player entered X as the LetraIngresada
	And Player entered Y as the LetraIngresada
	And Player entered J as the LetraIngresada
	And Player entered Q as the LetraIngresada
	And Player entered W as the LetraIngresada
	And Player entered Z as the LetraIngresada
	And Player entered P as the LetraIngresada
	Then Player should be told that he lost the game

@partida
Scenario: Player wins the game entering a word
	Given The word to guess 'AGILES'
	When Player entered A as the LetraIngresada
	And Player entered L as the LetraIngresada
	And Player entered S as the LetraIngresada
	And Player entered 'AGILES' as the PalabraIngresada
	Then Player should be told that he won the game

@partida
Scenario: Player loses the game entering a word
	Given The word to guess 'AGILES'
	When Player entered A as the LetraIngresada
	And Player entered L as the LetraIngresada
	And Player entered S as the LetraIngresada
	And Player entered 'ANCLAS' as the PalabraIngresada
	Then Player should be told that he lost the game