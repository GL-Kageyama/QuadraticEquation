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

print("Find the solution in the quadratic equation (a*x + b)*(c*x + d)= 0")
print("Enter the values ​​for a, b, c, and d in that order.")

aPre1=input()
aPre2=float(aPre1)
bPre1=input()
bPre2=float(bPre1)
cPre1=input()
cPre2=float(cPre1)
dPre1=input()
dPre2=float(dPre1)

a = aPre2*cPre2
b = aPre2*dPre2 + bPre2*cPre2
c = bPre2*dPre2

x1ans = QuadraticFuncPlus(a, b, c)
x2ans = QuadraticFuncMinus(a, b, c)

print("There are two solutions for x:")
print(x1ans)
print(x2ans)


