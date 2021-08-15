# Messing with functions in Pyton
# Yes I know that "snake_case" is the preferred in Python (duh), but I prefer camelCase. Sorry!

def main():
    hello()
    helloArg("Mario")
    helloArgDefault()
    helloArgDefault("Test")

    helloMultipleArgs("Mario", "Mario", "31/12/2019")

    helloMultipleArgsDefault("Luigi", "Mario")
    helloMultipleArgsDefault("Donkey", "Kong", "01/01/2021")

    alfabetise(["Mario", "Luigi", "Donkey", "Elsa", "Gustav", "Lion"])


def hello():  # Practice Function
    print("Hello!")


def helloArg(x):    # Practice function with argument
    print("Hello " + x)


# Same as above, but with a default value
def helloArgDefault(userName="Nobody"):
    print("Hello " + userName)


# Basically the same but with several arguments
def helloMultipleArgs(fName, lName, dateString):
    msg = "Hello " + fName + " " + lName
    msg += " you mentioned " + dateString
    print(msg)


# Same as above, but with a default value for datestring
def helloMultipleArgsDefault(fName, lName, dateString=""):
    msg = "Hello " + fName + " " + lName
    msg += " you mentioned " + dateString
    print(msg)


def alfabetise(originalList=[]):  # Passing a list into the function

    sortedList = originalList.copy()  # Copy the original list

    sortedList.sort()  # Sorting the copy

    finalList = ""  # Initialising the resulting comma separated string

    # Loops through the list and adds it to the string, adds a comma and a space at the end
    for name in sortedList:
        finalList += name+", "

    # Removes the two trailing chars at the end of the list.
    finalList = finalList[:-2]

    print(finalList)  # This obviously prints the comma separated string.


if __name__ == "__main__":
    main()
