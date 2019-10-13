from sympy import *
x=Symbol('x') 

print("Find the solution in the quadratic equation  a*x*x + b*x + c = 0")
print("Enter the values ​​for a, b, and c in that order.")

a = int(input())
b = int(input())
c = int(input())

sol = solve( a*x*x + b*x + c, x)
print(sol)

print("Find the solution in the quadratic equation a*(x - p)*(x - p) + q = 0")
print("Enter the values ​​for a, p, and q in that order.")

a = int(input())
p = int(input())
q = int(input())

sol = solve( a*(x - p)*(x - p) + q, x)
print(sol)

print("Find the solution in the quadratic equation (a*x + b)*(c*x + d)= 0")
print("Enter the values ​​for a, b, c, and d in that order.")

a = int(input())
b = int(input())
c = int(input())
d = int(input())

sol = solve( (a*x + b)*(c*x + d), x)
print(sol)


