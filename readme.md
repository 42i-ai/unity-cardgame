# Jogo de Cartas em Unity

Desenvolver o conceito de um jogo de cartas utilizando a Unity. O objetivo é implementar o jogo
utilizando conceitos de herança em C#. O jogo terá as seguintes classes:

## Classe Card (Carta): 

Essa classe será a classe base para todas as cartas do jogo.

### Atributos

- Nome da carta (string);
- Custo da carta (int) (Medido em moedas de ouro); 
- Raridade da carta enum: normal, raro, lendário;

## Classe CreatureCard (Carta Criatura): 

Essa classe herda da classe Card e representamas cartas que são criaturas no jogo. Além dos atributos herdados da classe Card, as cartas criatura.

### Atributos Adicionais: 
- Poder de ataque (int)
- Vida (int)

## Classe SpellCard (Carta de Magia): 

Essa classe também herda da classe Card e representa as cartas que são magias no jogo. Além dos atributos herdados da classe Card, as cartas
de magia.

### Atributo adicional:

- Efeito (string)

## Classe Deck (Baralho): 

Essa classe deve representar a coleção de cartas que o jogador
possui e pode levar para batalha. 

### Ela terá o seguinte atributo:

- Lista de cartas (List<Card>) 

### O métodos:

- **Adicionar carta()**: Esse método deve permitir adicionar uma carta na coleção respeitando o limite de um máximo de 10 cartas, sendo no máximo 1 delas lendária e 2 raras.
- **int Calcular valor total()**: Esse método deve retornar o valor total que todas as cartas somadas tem.

Exemplo: se a coleção tiver 7 cartas de valor 1 e 3 cartas de valor 2, o método deve retornar
13.

# Rules

Creating a Proof of Concept (POC) with a simplified version of the game using only five cards for each player can help you test the core mechanics. Here are the rules for this simplified version:

### Components
- Each player has 1 hero card and a mini-deck of 4 cards (a mix of action, item, and skill cards).

### Setup
1. Each player selects or is assigned a hero card with predefined abilities and HP.
2. Each player is dealt a mini-deck of 4 cards.
3. Players draw all 4 cards to form their starting hand.

### Turn Structure
1. **Draw Phase**: There is no draw phase since each player starts with all their cards in hand.
2. **Action Phase**: Players take turns performing actions using the cards in their hand. Each action costs Action Points (AP). Players have 2 AP per turn. Actions include:
   - **Attack**: Use an action card to deal damage to the opponent's hero.
   - **Defend**: Use an action card to reduce incoming damage.
   - **Use Item**: Use an item card to equip weapons/armor or consume potions.
   - **Activate Skill**: Use a skill card to perform a special ability (healing, buffing, debuffing, etc.).
3. **End Phase**: The player ends their turn, and the next player begins their turn.

### Winning the Game
- The goal is to reduce the opponent's hero's HP to 0.

### Example Cards
1. **Hero Card**: "Warrior"
   - HP: 10
   - Ability: "Battle Cry" (Once per game, double the damage of an attack card for one turn)

2. **Action Card**: "Sword Slash"
   - AP Cost: 1
   - Damage: 3

3. **Action Card**: "Shield Block"
   - AP Cost: 1
   - Effect: Reduce incoming damage by 3 for one turn

4. **Item Card**: "Healing Potion"
   - AP Cost: 1
   - Effect: Restore 3 HP to the hero

5. **Skill Card**: "Quick Strike"
   - AP Cost: 2
   - Damage: 5

### Example Turn
1. Player 1's Turn:
   - Uses "Sword Slash" (costs 1 AP) to deal 3 damage to Player 2's hero.
   - Uses "Healing Potion" (costs 1 AP) to restore 3 HP to their hero.
   - Ends turn.

2. Player 2's Turn:
   - Uses "Quick Strike" (costs 2 AP) to deal 5 damage to Player 1's hero.
   - Ends turn.

### Simplified Mechanics
- **No Deck Building**: Players use pre-selected cards to simplify testing.
- **Single Use Cards**: Each card can be used only once for the POC.
- **Limited Turns**: Set a maximum number of turns (e.g., 5 turns each) to ensure the game concludes quickly.

This simplified version of the game allows you to test the core mechanics, balance the card effects, and gather feedback before expanding to a full deck and more complex rules.

# Referencias

(How to make a CARD GAME - Unity Tutorial 2022)[https://www.youtube.com/watch?v=C5bnWShD6ng]
(How to Create a 2D Card Game in Unity - Part 1 (Setup and Basic Game Architecture))[https://www.youtube.com/watch?v=0-dUB52eEMk]