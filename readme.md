# Jogo de Cartas em Unity

Desenvolver o conceito de um jogo de cartas utilizando a Unity. O objetivo é implementar o jogo
utilizando conceitos de herança em C#. O jogo terá as seguintes classes:

Git do projeto: https://github.com/42i-ai/unity-cardgame

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

## Regras do Jogo próxima versão

### Regras do Jogo de Cartas da Sociedade do Anel vs. Exército de Sauron

#### Objetivos

- **Jogador da Sociedade do Anel**: Destruir o One Ring.
- **Jogador do Exército de Sauron**: Matar Frodo Baggins.

#### Configuração Inicial

1. **Baralho**: Cada jogador começa com um baralho de 10 cartas. O baralho deve ser embaralhado antes do início do jogo.
2. **Mão Inicial**: Cada jogador compra 5 cartas do topo do seu baralho para formar sua mão inicial.
3. **Turnos**: Decida aleatoriamente qual jogador começa.

#### Turnos

Cada turno consiste nas seguintes fases:

1. **Compra de Carta**: No início de cada turno, o jogador compra uma carta do topo do seu baralho, se tiver menos de 5 cartas na mão.
2. **Fase de Invocação**: O jogador pode usar ouro (custo das cartas) para invocar criaturas ou lançar feitiços. Cada jogador começa com 5 de ouro e ganha 1 de ouro adicional por turno.
3. **Fase de Combate**: O jogador pode atacar com suas criaturas.
4. **Fase Final**: O jogador termina o turno, passando a vez para o oponente.

#### Regras de Combate

1. **Ataque**: Durante a fase de combate, o jogador pode escolher quais criaturas irão atacar.
2. **Defesa**: O jogador defensor pode escolher quais criaturas irão defender.
3. **Dano**: O dano de ataque é subtraído da vida das criaturas defensoras. Se uma criatura receber dano igual ou superior à sua vida, ela é destruída e removida do campo de batalha.
4. **Ataque Direto**: Se uma criatura atacante não for bloqueada, ela pode atacar diretamente o jogador ou um objetivo específico (Frodo ou o One Ring).

#### Condições de Vitória

- **Jogador do Exército de Sauron**: Vence se conseguir reduzir a vida de Frodo a 0.
- **Jogador da Sociedade do Anel**: Vence se conseguir destruir o One Ring usando a carta de feitiço "Flames of Mount Doom" ou qualquer outra condição de destruição específica para o One Ring.

#### Regras Especiais

1. **Frodo Baggins**: Frodo é uma carta especial e não pode ser atacado diretamente a menos que todas as outras criaturas do jogador da Sociedade do Anel estejam destruídas.
2. **One Ring**: O One Ring pode ser destruído apenas por cartas ou efeitos específicos, como "Flames of Mount Doom".

#### Invocação e Lançamento de Feitiços

- O jogador pode invocar criaturas ou lançar feitiços durante sua fase de invocação, desde que tenha ouro suficiente.
- Cada jogador começa com 5 de ouro e ganha 1 de ouro adicional por turno.

#### Limite de Mão

- Cada jogador pode ter no máximo 7 cartas na mão. Se um jogador tiver mais de 7 cartas, deve descartar até ter 7.

#### Efeitos de Cartas

- Alguns feitiços e habilidades de criaturas têm efeitos que podem alterar o curso do jogo. Estes são resolvidos imediatamente quando a carta é jogada.



# Referencias

(How to make a CARD GAME - Unity Tutorial 2022)[https://www.youtube.com/watch?v=C5bnWShD6ng]
(How to Create a 2D Card Game in Unity - Part 1 (Setup and Basic Game Architecture))[https://www.youtube.com/watch?v=0-dUB52eEMk]