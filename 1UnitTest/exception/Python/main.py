import sys

try:
    print("Enter first number")
    num1 = float(input())

    print("Enter second number")
    num2 = float(input(input))

    res = num1 / num2
except Exception as e:
    print("Error! " + str(e))


print(sys.getsizeof(int))
print(sys.getsizeof(float))