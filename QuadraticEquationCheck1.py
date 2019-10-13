import cmath

def QuadraticFuncPlus(a, b, c):

	try:
		x1 = (-b + cmath.sqrt(b**2 - 4*a*c)) / 2*a
	except:
		print("Error")

	return x1

def QuadraticFuncMinus(a, b, c):

	try:
		x2 = (-b - cmath.sqrt(b**2 - 4*a*c)) / 2*a
	except:
		print("Error")

	return x2

print("Find the solution in the quadratic equation  a*x*x + b*x + c = 0")
print("Enter the values ​​for a, b, and c in that order.")

aPre=input()
a=float(aPre)
bPre=input()
b=float(bPre)
cPre=input()
c=float(cPre)

x1ans = QuadraticFuncPlus(a, b, c)
x2ans = QuadraticFuncMinus(a, b, c)

print("There are two solutions for x:")
print(x1ans)
print(x2ans)



