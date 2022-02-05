from operator import truediv


def digital_root(n):
  reduce = True
  tempVal = n
  while reduce:
    sum = 0
    for num in list(str(tempVal)):
      sum += int(num)
    tempVal = sum
    if sum < 10:
      reduce = False
  return sum

print(digital_root(16)) #should return 7
print(digital_root(942)) #should return 6
print(digital_root(132189)) #should return 6
print(digital_root(493193)) #should return 2