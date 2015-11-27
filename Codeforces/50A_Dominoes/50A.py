import math

s = str.split(input())
M = int(s[0])
N = int(s[1])

if M%2 == 0 or N%2 == 0:
	print(int(M*N/2))
else:
	if M%2 == 0:
		print(int(M*(N-1)/2 + math.floor(M/2)))
	elif N%2 == 0:
		print(int(N*(M-1)/2 + math.floor(N/2)))
	else:
		print(int(M*(N-1)/2 + math.floor(M/2)))