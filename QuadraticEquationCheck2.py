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

print("Find the solution in the quadratic equation a*(x - p)*(x - p) + q = 0")
print("Enter the values ​​for a, p, and q in that order.")

aPre1=input()
aPre2=float(aPre1)
pPre1=input()
pPre2=float(pPre1)
qPre1=input()
qPre2=float(qPre1)

a = aPre2
b = -2*aPre2*pPre2
c = aPre2*pPre2**2 + qPre2

x1ans = QuadraticFuncPlus(a, b, c)
x2ans = QuadraticFuncMinus(a, b, c)

print("There are two solutions for x:")
print(x1ans)
print(x2ans)



