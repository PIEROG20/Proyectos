import random
import os

def run():
    IMAGES = ['''
  +---+
  |   |
      |
      |
      |
      |
=========''', '''
  +---+
  |   |
  O   |
      |
      |
      |
=========''', '''
  +---+
  |   |
  O   |
  |   |
      |
      |
=========''', '''
  +---+
  |   |
  O   |
 /|   |
      |
      |
=========''', '''
  +---+
  |   |
  O   |
 /|\  |
      |
      |
=========''', '''
  +---+
  |   |
  O   |
 /|\  |
 /    |
      |
=========''', '''
  +---+
  |   |
  O   |
 /|\  |
 / \  |
      |
=========''']

    DB = [
        "c",
        "python",
        "javascript",
        "java",
        "php"
    ]

    word = random.choice(DB)
    spaces = ["_"] * len(word)
    attempts = 6

    while True:
        os.system('cls' if os.name == 'nt' else 'clear')  # limpia pantalla (Windows/Linux)
        
        # Mostrar progreso
        for character in spaces:
            print(character, end=" ")
        print("\n")
        print(IMAGES[6 - attempts])   # mostrar dibujo correcto según intentos fallados

        letter = input("Elige una letra: ").lower()

        found = False
        for index, character in enumerate(word):
            if character == letter:
                spaces[index] = character
                found = True

        if not found:
            attempts -= 1

        if "_" not in spaces:
            os.system('cls' if os.name == 'nt' else 'clear')
            print("¡Ganaste! La palabra era:", word)
            input("Presiona Enter para salir...")
            break

        if attempts == 0:
            os.system('cls' if os.name == 'nt' else 'clear')
            print("¡Perdiste! La palabra era:", word)
            print(IMAGES[-1])
            input("Presiona Enter para salir...")
            break


if __name__ == '__main__':
    run()
