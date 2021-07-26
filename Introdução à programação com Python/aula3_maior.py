# a = int(input("Primeiro valor: "))
# b = int(input("Segundo valor: "))
# if a > b:
# 	# print("A é maior")
# 	print(f"O maior número é {a}")
# else:
# 	# print("B é maior")
# 	print(f"O maior número é {b}")

a = int(input("Valor de A: "))
b = int(input("Valor de B: "))
c = int(input("Valor de C: "))

if a > b and a > c:
    print(f"A=({a}) é o maior valor")
elif b > a and b > c:
    print(f"B=({b}) é o maior valor")
else:
    print(f"C=({c}) é o maior valor")
print("Fim do programa!!!")