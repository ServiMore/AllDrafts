def saludar(nombre):
    return"Hola {}".format(nombre)

print("ingrese su nombre")
nombre = input()
print(saludar(nombre))