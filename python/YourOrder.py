def order(sentence):
  if (sentence == ""): return ""
  words = sentence.split()
  answer = [None] * len(words)
  for word in words:
    for letter in word:
      if (letter.isdigit()):
        answer[int(letter)-1] = word
  return " ".join(answer)

print(order("is2 Thi1s T4est 3a"))
# should return "Thi1s is2 3a T4est"
print(order("4of Fo1r pe6ople g3ood th5e the2"))
# should return "Fo1r the2 g3ood 4of th5e pe6ople"
print(order(""))
# should return ""