import cmath

def QuadraticFuncPlus(a, b, c):

	x1 = (-b + cmath.sqrt(b**2 - 4*a*c)) / 2*a

	return x1

def QuadraticFuncMinus(a, b, c):

	x2 = (-b - cmath.sqrt(b**2 - 4*a*c)) / 2*a

	return x2

print("2次方程式 (a*x + b)*(c*x + d)= 0 における解を求めます。")

print("a を入力してください")
aPre1=input()
aPre2=float(aPre1)

print("b を入力してください")
bPre1=input()
bPre2=float(bPre1)

print("c を入力してください")
cPre1=input()
cPre2=float(cPre1)

print("d を入力してください")
dPre1=input()
dPre2=float(dPre1)

a = aPre2*cPre2
b = bPre2*cPre2
c = aPre2*dPre2 + bPre2*dPre2

x1ans = QuadraticFuncPlus(a, b, c)
x2ans = QuadraticFuncMinus(a, b, c)

print("xの解は以下の２つです")
print(x1ans)
print(x2ans)


