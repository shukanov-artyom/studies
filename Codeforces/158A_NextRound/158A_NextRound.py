import sys

line1 = str.split(input(), ' ')
line2 = str.split(input(), ' ')

n = int(line1[0])
k = int(line1[1]) - 1

minMark = int(line2[k])

c = 0
for x in line2:
	xint = int(x)
	if xint >= minMark and xint > 0:
		c += 1
	else:
		break
print(c)