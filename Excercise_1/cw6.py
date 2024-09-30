x = input("Podaj liczbe x: ")
y = input("Podaj liczbe y: ")

x_split = x.split(".")
y_split = y.split(".")

if (len(x_split) > 1 and len(y_split) > 1):
    print(f"Dla x czesc calkowita wynosi {x_split[0]} a czesc ulamkowa: {x_split[1]}")
    print(f"Dla y czesc calkowita wynosi {y_split[0]} a czesc ulamkowa: {y_split[1]}")

x = int(float(x))
y = int(float(y))

div = x % y

print(f"Reszta z dzielenia x: {x} od y: {y} wynosi: {div}")

mass = input("Podaj mase ciala (w kg!): ")
height = input("Podaj wzrost ciala (w metrach!): ")

mass = float(mass)
height = float(height)

bmi = mass / (height**2)

print(f"BMI wynosi: {bmi}")
