Zahlen = [5,2,7,7,3,5,43,6,6,6,45,4,534,657,652,5,457,4,6,754,753,]
Zahlenlänge = len(Zahlen)

#Das arithemtische Mittel
Durchschnitt = sum(Zahlen)/len(Zahlen)
print('der Durchschnitt ist', Durchschnitt)

#Der Median
Zahlen.sort()
MedianPosition = int(len(Zahlen)/2)
print(Zahlen[MedianPosition])

#Modus
def Modus (dataset):
    frequency = {}

    for value in dataset:
        frequency[value] = frequency.get(value, 0)

        most_frequent = max(frequency.values())

        modes = [key for key, value in frequency.items()
        if value == most_frequent]
    return modes

print(Modus(Zahlen))
#Skalenniveau