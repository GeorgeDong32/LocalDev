
import numpy as np
import matplotlib.pyplot as plt

X = np.linspace(-np.pi, np.pi, 256, endpoint=True)
C, S = np.cos(X), np.sin(X)
a = 2
b = 3

plt.plot(X, C)
plt.plot(X, S)

plt.show()
