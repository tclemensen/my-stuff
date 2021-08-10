#¤// simple (hopefully) fuel usage calculator that will estimate the amount of fuel used and the cost for a road trip

print("This is the awesome fuel consumption / cost calculator/estimator for a road trip")

print("Please enter estimated average fuel price: ")
fuelPrice=float(input())

mpg=float(input("Enter estimated fuel consumption in l/100km (e.g 8.3): "))
kmDriven=float(input("Enter number of km: "))
tankSize=float(input("Enter the size of your fuel tank: "))


fuelTotalAmount=(kmDriven*(mpg/100))
fuelTotalPrice=fuelTotalAmount*fuelPrice
numberRefuelings=fuelTotalAmount/(tankSize*0.88) ## Assuming a safety margin of 12% 

print("Based on the information you have given, this app estimates the following:")
print("On a road trip of " + str(kmDriven) + " km, you will use " + str(fuelTotalAmount) + " liters of fuel")
print("The total fuel cost will be "+ str(fuelTotalPrice) + " kr")

print("You will have to refuel " + str(round(numberRefuelings)) + " times")