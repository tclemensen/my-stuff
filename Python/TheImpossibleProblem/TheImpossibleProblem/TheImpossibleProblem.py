# Simple python app dealing with "The Impossible Problem" aka 3n+1, with absolutely no claims of solving it 


print("The Impossible Problem - Iteration Counter")

# Initialising some variables

i = 0 
iMax = 0
y = 0
x = 0 


for x in range(1,100000):
    
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



    
