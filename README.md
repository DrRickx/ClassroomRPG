README.txt

Title: Classmates RPG Battle Simulator 

Characters:

- Character 1: Fighter Nelson  
  Nelson is a powerful fighter known for his high attack power and close-range combat skills. He uses brute force and quick strikes to defeat his enemies.

- Character 2: Paladin Alex  
  Alex is a noble paladin who specializes in healing and defense. With his strong armor and healing abilities, he supports his team while also fighting off evil with his sword.

How OOP Principles Were Applied:

1. Encapsulation:  
   Each character’s stats (like health, attack, and defense) are stored in private variables and accessed or modified using getter and setter methods. This keeps the data secure and organized.

2. Abstraction:  
   We used abstract classes or interfaces (like a base Character class) to define shared behaviors such as Attack() or Defend(). This hides unnecessary details and focuses on important functions.

3. Inheritance:  
   Both Fighter Nelson and Paladin Alex inherit from a common Character base class. This helps reduce code duplication by reusing common logic like movement, damage calculation, etc.

4. Polymorphism:  
   Each character overrides shared methods like Attack() in their own way. For example, Nelson has a strong melee attack, while Alex has a weaker attack but can also heal himself or others.

Challenges Faced:

- Understanding how to correctly apply polymorphism in a real situation was tricky at first.
- Debugging method overrides was challenging, especially when the base class method didn’t behave as expected in child classes.
- Balancing the characters to make sure they had fair strengths and weaknesses required a lot of testing and tweaking.
