# ¤// simple (hopefully) fuel usage calculator that will estimate the amount of fuel used and the cost for a road trip

import os


def main():

    clearConsole()

    print("This is the awesome fuel consumption / cost calculator/estimator for a road trip")

    askForInput()

    ## results = askForInput()
    # calculateValues(results[1],results[2],results[3],resu[4])


def clearConsole():
    if os.name in ("nt", "dos"):
        command = "cls"
    else:
        command = "clear"
    os.system(command)


def askForInput():
    print("Please enter estimated average fuel price: ")
    fuelPrice = input()
    tankSize = input("Enter the size of your fuel tank: ")
    fuelConsumption = input(
        "Enter estimated fuel consumption in l/100km (e.g 8.3): ")
    kmDriven = input("Enter number of km: ")

    results = [fuelPrice, tankSize, fuelConsumption, kmDriven]

    calculateValues(float(fuelPrice), float(tankSize),
                    float(fuelConsumption), float(kmDriven))

    return results


def calculateValues(fuelPrice, tankSize, mpg, kmDriven):

    fuelTotalAmount = (kmDriven*(mpg/100))
    fuelTotalPrice = fuelTotalAmount * fuelPrice
    # Assuming a safety margin of 12%.
    numberRefuelings = fuelTotalAmount/(tankSize * 0.88)
    printResult(kmDriven, fuelTotalAmount, fuelTotalPrice, numberRefuelings)


def printResult(kmDriven, fuelTotalAmount, fuelTotalPrice, numberRefuelings):
    print("Based on the information you have given, this app estimates the following:")
    print("On a road trip of " + str(kmDriven) + " km, you will use " +
          str(round(fuelTotalAmount)) + " liters of fuel")
    print("The total fuel cost will be " +
          "{:,.2f}".format(fuelTotalPrice) + " kr")
    print("You will have to refuel " + str(round(numberRefuelings)) + " times")


if __name__ == "__main__":
    main()
