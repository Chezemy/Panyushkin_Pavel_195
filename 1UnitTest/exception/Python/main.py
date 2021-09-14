import sys

try:
    print("Enter first number")
    num1 = float(input())

    print("Enter second number")
    num2 = float(input())

    res = num1 / num2
    print("Result: " + str(res))
except Exception as e:
    print("Error! " + str(e))


print("Size of integer: " + str(sys.getsizeof(int())))
print("Size of float: " + str(sys.getsizeof(float())))