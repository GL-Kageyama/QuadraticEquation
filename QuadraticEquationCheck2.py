import cmath

def QuadraticFuncPlus(a, b, c):

	x1 = (-b + cmath.sqrt(b**2 - 4*a*c)) / 2*a

	return x1

def QuadraticFuncMinus(a, b, c):

	x2 = (-b - cmath.sqrt(b**2 - 4*a*c)) / 2*a

	return x2

print("2次方程式 a*(x - p)*(x - p) + q = 0 における解を求めます。")

print("a を入力してください")
aPre1=input()
aPre2=float(aPre1)

print("p を入力してください")
pPre1=input()
pPre2=float(pPre1)

print("q を入力してください")
qPre1=input()
qPre2=float(qPre1)

a = aPre2
b = -2*aPre2*pPre2
c = aPre2*pPre2**2 + qPre2

x1ans = QuadraticFuncPlus(a, b, c)
x2ans = QuadraticFuncMinus(a, b, c)

print("xの解は以下の２つです")
print(x1ans)
print(x2ans)



