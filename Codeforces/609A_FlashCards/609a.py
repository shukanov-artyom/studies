n = int(input())
m = int(input())
ns = []
for i in range(0, n):
    ns.append(int(input()))

result = 0
remainderBytes = m

for si in sorted(ns, reverse=True):
    remainderBytes -= si
    result += 1
    if remainderBytes <= 0:
        break

print(result)
