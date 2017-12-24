import math

def Prime( checkem ):
	if checkem == 0: return False
	if checkem == 1: return False
	if checkem == 2: return True
	if checkem % 2 == 0: return False
	for i in range(3,int(math.sqrt(checkem))+1,2):
		if checkem % i == 0: return False
	return True

for i in range(1000):
	if Prime(i): print(i)


