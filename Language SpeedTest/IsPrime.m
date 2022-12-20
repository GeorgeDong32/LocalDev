% check is input number is prime
function isprime = IsPrime(input)
    isprime = true;

    for i = 2:sqrt(input) + 1

        if mod(input, i) == 0
            isprime = false;
            break
        end

    end

end
