% Count the prime numbers in the range 1 to 1000000
% 9.387980s on RYZEN 5 5600H with MATLAB 2022b
startTime = tic;
count = 0;

for i = 2:1000000

    if isprime(i)
        count = count + 1;
    end

end

fprintf('Found %d prime numbers',count);
t = toc(startTime);
fprintf('Elapsed time is %f seconds.', t);
