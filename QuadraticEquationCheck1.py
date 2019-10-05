import cmath

def QuadraticFuncPlus(a, b, c):

	x1 = (-b + cmath.sqrt(b**2 - 4*a*c)) / 2*a

	return x1

def QuadraticFuncMinus(a, b, c):

	x2 = (-b - cmath.sqrt(b**2 - 4*a*c)) / 2*a

	return x2

print("2次方程式 a*x*x + b*x + c = 0 における解を求めます。")

print("a を入力してください")
aPre=input()
a=float(aPre)

print("b を入力してください")
bPre=input()
b=float(bPre)

print("c を入力してください")
cPre=input()
c=float(cPre)

x1ans = QuadraticFuncPlus(a, b, c)
x2ans = QuadraticFuncMinus(a, b, c)

print("xの解は以下の２つです")
print(x1ans)
print(x2ans)



