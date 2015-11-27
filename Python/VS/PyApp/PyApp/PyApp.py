wovels = "AOYEUI"
a = input()
result = ""
for char in a:
    if not char in wovels and not char in wovels.lower():
        result += "."
        result += char if char.islower() else char.lower()
print(result)
