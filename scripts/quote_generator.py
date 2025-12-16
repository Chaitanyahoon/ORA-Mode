import random

def get_jojo_quote():
    quotes = [
        "Yare Yare Daze...",
        "I, Giorno Giovanna, have a dream.",
        "You thought it was a clean build, but it was ME, DIO!",
        "USELESS! USELESS! USELESS!",
        "The World! Stop the runtime!",
        "Code is Unbreakable."
    ]
    return random.choice(quotes)

if __name__ == "__main__":
    print(f"Random Quote: {get_jojo_quote()}")
