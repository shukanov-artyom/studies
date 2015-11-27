import sys

w = int(input())
if w % 2 != 0:
	print('NO')
	sys.exit()
else:
	c = 2
	while c < w:
		if (w - c) % 2 == 0:
			print('YES')
			sys.exit()
		c += 2 
	print('NO')
	