"""Count the prime numbers in the range [1, n]
"""
# 0.19631648063659668s on RYZEN 5 5600H

import taichi as ti
ti.init(arch=ti.cpu)
import time
start = time.time()

@ti.func
def is_prime(n: int):
    result = True
    for k in range(2, int(n ** 0.5) + 1):
        if n % k == 0:
            result = False
            break
    return result

@ti.kernel
def count_primes(n: int) -> int:
    count = 0
    for k in range(2, n):
        if is_prime(k):
            count += 1

    return count

print(count_primes(1000000))

end = time.time()
print("Time elapsed: ", end - start)