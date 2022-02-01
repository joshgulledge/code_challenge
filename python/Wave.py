def wave(people):
  arr = []
  letters = list(people)

  for i in range(len(people)):
    if letters[i] == " ":
      continue
    letters[i] = letters[i].upper()
    arr.append("".join(letters.copy()))
    letters[i] = letters[i].lower()

  return arr

print(wave("hello"))
print(wave("Two words"))