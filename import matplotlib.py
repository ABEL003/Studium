import matplotlib
from scipy.stats import binom

def plot_binomial_distribution(n, p, x):
    # Wahrscheinlichkeitsverteilung für die Binomialverteilung berechnen
    dist = binom(n, p)
    x_values = range(n+1)
    y_values = [dist.pmf(i) for i in x_values]

    # Diagramm erstellen
    plt.bar(x_values, y_values, color='blue', alpha=0.7)
    plt.title(f'Binomialverteilung (n={n}, p={p})')
    plt.xlabel('Anzahl der Erfolge (x)')
    plt.ylabel('Wahrscheinlichkeit')
    plt.xticks(x_values)

    # Markiere den spezifizierten Wert von x
    plt.axvline(x=x, color='red', linestyle='--', label=f'x={x}')
    plt.legend()

    # Diagramm anzeigen
    plt.show()

# Variablen
n = 7
p = 0.9
x = 4

plot_binomial_distribution(n, p, x)