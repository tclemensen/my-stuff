# ¤// simple (hopefully) fuel usage calculator that will estimate the amount of fuel used and the cost for a road trip

import os


def main():

    clearConsole()

    print("This is the awesome fuel consumption / cost calculator/estimator for a road trip")

    result = askForInput()

    result2 = calculateValues(result[0], result[1], result[2], result[3])

    printResult(result2[0], result2[1], result2[2], result2[3])


def clearConsole():
    if os.name in ("nt", "dos"):
        command = "cls"
    else:
        command = "clear"
    os.system(command)


def askForInput():

    fuelPrice = float(input("Enter the estimated average fuel price: "))
    tankSize = float(input("Enter the size of your fuel tank in liter: "))
    fuelConsumption = float(
        input("Enter estimated fuel consumption in l/100km (e.g 8.3): "))
    kmDriven = float(input("Enter number of km: "))

    return [fuelPrice, tankSize, fuelConsumption, kmDriven]


def calculateValues(fuelPrice, tankSize, mpg, kmDriven):

    fuelTotalAmount = (kmDriven*(mpg/100))
    fuelTotalPrice = fuelTotalAmount * fuelPrice
    # Assuming a safety margin of 12%.
    numberRefuelings = fuelTotalAmount/(tankSize * 0.88)

    ## printResult(kmDriven, fuelTotalAmount, fuelTotalPrice, numberRefuelings)

    return [kmDriven, fuelTotalAmount, fuelTotalPrice, numberRefuelings]


def printResult(kmDriven, fuelTotalAmount, fuelTotalPrice, numberRefuelings):
    print("Based on the information you have given, this app estimates the following:")
    print("On a road trip of " + str(kmDriven) + " km, you will use " +
          str(round(fuelTotalAmount)) + " liters of fuel")
    print("The total fuel cost will be " +
          "{:,.2f}".format(fuelTotalPrice) + " kr")
    print("You will have to refuel " + str(round(numberRefuelings)) + " times")


if __name__ == "__main__":
    main()
