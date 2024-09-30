## Cw - P7
## Zadanie Domowe, 24.09.2024
#

list1 = [3, 3, 8, 9, 2, 5, 7]
print(list1)

for v in list1:
    print(int(v))

list1.remove(8)

print(list1[-2::-2])
list1.insert(3,7)

print(len(list1))

svs = 0 

for v in list1:
    if v == 7:
        svs += svs

print(svs)

list2 = [x for x in range (1,8) if x % 2 != 0]
print(list2)

list1.append(list2)

print(list1)
print(len(list1))

tupla = (33,55,77)
print(tupla)
tupla = tuple(list(tupla) + list2)
print(tupla)
print(tuple(list(tupla).sort()))

symetryczna = list2[::-1]
print(symetryczna)
