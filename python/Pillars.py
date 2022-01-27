def pillars(num_pill, dist, width):
    return 0 if num_pill == 1 else (((dist * 100) * (num_pill-1)) + (width * (num_pill-1))) - width

print(pillars(1, 10, 10))
print(pillars(2, 20, 25))
print(pillars(11, 15, 30))
