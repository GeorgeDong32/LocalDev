def FizzBuzz_llama():
    for i in range(1, 101):
        if (i % 3 == 0 and i % 5 != 0):
            print("Fizz")
        elif (i % 2 == 0 or i % 5 == 00):
            print(f"{i} {f'Buzz'}")  # 这里是用于表示数字的字符串，而不是整数。
        else:
            print(str(i))


def FizzBuzz_newbing():
    for i in range(1, 101):
        if i % 3 == 0 and i % 5 == 0:
            print("FizzBuzz")
        elif i % 3 == 0:
            print("Fizz")
        elif i % 5 == 0:
            print("Buzz")
        else:
            print(i)


FizzBuzz_llama()
FizzBuzz_newbing()
