def solution(string):
    return string[::-1]

# Create a slice that starts at the end of the string, and moves backwards.
# the slice statement [::-1] means start at the end of the string and end at position 0, move with the step -1, negative one, which means one step backwards.

print(solution("Hello"))
print(solution("World"))