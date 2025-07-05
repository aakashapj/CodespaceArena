import random

class Dice:
    NUMBER_OF_SIDES = 6

    def __init__(self, rng: random.Random) -> None:
        self._random = rng

    def roll(self) -> int:
        return self._random.randint(1, self.NUMBER_OF_SIDES)


class UserInteraction:
    def get_input(self, message: str) -> int :
        userInput: str = input(message)

        while 
        return 0



if __name__ == "__main__":
    myRandom = random.Random()
    rolled_number: int =  Dice(myRandom).roll()
    print("Dice rolled. Guess what number it shows in 3 tries.")
    userInput = input("Enter Number").isdigit()
    print(userInput)


