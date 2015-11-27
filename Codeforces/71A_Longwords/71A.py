import sys

results = []
n = int(input())
while n > 0:
	s = input()
	length = len(s)
	if length <= 10: 
		results.append(s)
	else:
		result = s[0]
		ctr = 0
		for i in range(1, length-1):
			ctr += 1
		result += str(ctr)
		result += s[length-1]
		results.append(result)
	n = n-1
for res in results:
	print(res)

