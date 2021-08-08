# Simple python app dealing with "The Impossible Problem" aka 3n+1, with absolutely no claims of solving it 
# The program will run through a number of attempts, and spit out the highest number of loops it encountered
# in the range. Potentials for adding more information but I don't bother. 


print("The Impossible Problem - Iteration Counter")

# Initialising some variables

iMax = 0


for x in range(1,20000):
    
    y=x
    i=0

    while y != 1:
        if (y % 2) == 0:
            y = y / 2
        else:
            y = (3 * y) + 1
        
        i=i + 1
        
        if iMax<i:
            iMax=i

print("Highest number of iterations reached: " + str(iMax))



    
