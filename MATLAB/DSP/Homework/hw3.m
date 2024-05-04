% 定义参数
Fs = 500; % 采样频率
T = 1/Fs; % 采样周期
L = 1000; % 信号长度
t = (0:L-1)*T; % 时间向量

% 生成480Hz和50Hz的正弦波和方波
A = 0.5; % 幅度
f1 = 480; % 频率
f2 = 50; % 频率
x1 = A*sin(2*pi*f1*t); % 480Hz正弦波
x2 = A*sin(2*pi*f2*t); % 50Hz正弦波
x3 = A*square(2*pi*f1*t); % 480Hz方波
x4 = A*square(2*pi*f2*t); % 50Hz方波

% 使用FFT计算频谱
NFFT = 2^nextpow2(L); % 下一个2的幂
Y1 = fft(x1,NFFT)/L;
Y2 = fft(x2,NFFT)/L;
Y3 = fft(x3,NFFT)/L;
Y4 = fft(x4,NFFT)/L;
f = Fs/2*linspace(0,1,NFFT/2+1);

% 画出480Hz正弦波及其频谱
figure;
subplot(2,1,1);
p1 = plot(t(1:50), x1(1:50), 'b-');
hold on;
p2 = plot(t(1:50), x1(1:50), 'r.');
hold off;
title('480Hz正弦波');
legend([p1, p2], {'信号', '采样点'});
subplot(2,1,2);
plot(f,2*abs(Y1(1:NFFT/2+1)));
title('480Hz正弦波频谱');
xlim([0 300]);
saveas(gcf, '480Hz_sine_wave.png');

% 画出50Hz正弦波及其频谱
figure;
subplot(2,1,1);
p1 = plot(t(1:50), x2(1:50), 'b-');
hold on;
p2 = plot(t(1:50), x2(1:50), 'r.');
hold off;
title('50Hz正弦波');
legend([p1, p2], {'信号', '采样点'});
subplot(2,1,2);
plot(f,2*abs(Y2(1:NFFT/2+1)));
title('50Hz正弦波频谱');
xlim([0 300]);
saveas(gcf, '50Hz_sine_wave.png');

% 画出480Hz方波及其频谱
figure;
subplot(2,1,1);
p1 = plot(t(1:50), x3(1:50), 'b-');
hold on;
p2 = plot(t(1:50), x3(1:50), 'r.');
hold off;
title('480Hz方波');
legend([p1, p2], {'信号', '采样点'});
subplot(2,1,2);
plot(f,2*abs(Y3(1:NFFT/2+1)));
title('480Hz方波频谱');
xlim([0 300]);
saveas(gcf, '480Hz_square_wave.png');

% 画出50Hz方波及其频谱
figure;
subplot(2,1,1);
p1 = plot(t(1:50), x4(1:50), 'b-');
hold on;
p2 = plot(t(1:50), x4(1:50), 'r.');
hold off;
title('50Hz方波');
legend([p1, p2], {'信号', '采样点'});
subplot(2,1,2);
plot(f,2*abs(Y4(1:NFFT/2+1)));
title('50Hz方波频谱');
xlim([0 300]);
saveas(gcf, '50Hz_square_wave.png');